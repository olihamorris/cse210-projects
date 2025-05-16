using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most fascinating person you met today?",
            "What made today stand out for you?",
            "How did you experience divine guidance today?",
            "What emotion dominated your day, and why?",
            "If you could relive one moment from today, what would it be?",
            "What did you learn about yourself today?",
            "What is something you're looking forward to tomorrow?"
        };

        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease choose one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry { Date = date, Prompt = prompt, Response = response };
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter the filename: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the filename: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static string GetRandomPrompt(List<string> prompts)
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}