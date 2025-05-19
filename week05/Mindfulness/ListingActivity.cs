using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "Who are your personal heroes?"
    };

    public ListingActivity() : base("Listing", 
        "This activity will help you reflect on the good things in your life.") {}

    public void Run()
    {
        Start();
        Random rnd = new Random();
        Console.WriteLine("\n" + _prompts[rnd.Next(_prompts.Count)]);
        Console.WriteLine("\nStart listing items. Press Enter after each. Begin now!");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");
        End();
    }
}