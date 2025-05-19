using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by guiding you through slow breathing.") {}

    public void Run()
    {
        Start();
        int cycle = _duration / 6;
        for (int i = 0; i < cycle; i++)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
        }
        End();
    }
}