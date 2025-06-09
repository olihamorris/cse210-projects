using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    public int TotalPoints { get; private set; }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Goal goal = null;
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goal = new SimpleGoal();
                break;
            case 2:
                goal = new EternalGoal();
                break;
            case 3:
                goal = new ChecklistGoal();
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                ((ChecklistGoal)goal).GetType()
                    .GetField("TargetCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.SetValue(goal, target);
                ((ChecklistGoal)goal).GetType()
                    .GetField("Bonus", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    ?.SetValue(goal, bonus);
                break;
        }

        goal.Name = name;
        goal.Description = desc;
        goal.Points = points;

        _goals.Add(goal);
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(TotalPoints);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        TotalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal goal = null;

            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal();
                    break;
                case "EternalGoal":
                    goal = new EternalGoal();
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal();
                    break;
            }

            goal?.Deserialize(lines[i]);
            if (goal != null) _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            TotalPoints += _goals[index].Points;
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}