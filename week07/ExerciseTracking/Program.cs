using System; 
using System.Collections.Generic;

// Base class
abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance();  // in miles
    public abstract double GetSpeed();     // mph
    public abstract double GetPace();      // min/mile

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}

// Running class
class Running : Activity
{
    private double _distance;  // in miles

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / _distance;
}

// Cycling class
class Cycling : Activity
{
    private double _speed;  // in mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * GetMinutes()) / 60;

    public override double GetSpeed() =>_speed;

    public override double GetPace() => 60 / _speed;
}

// Swimming class
class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;  // converting to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 9.7),
            new Swimming("03 Nov 2022", 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}