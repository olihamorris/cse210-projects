using System;

class Program 
{
    static void Main() 
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        int guess;
        while (true) 
        {
            Console.Write("What is your guess? ");
            if (int.TryParse(Console.ReadLine(), out guess)) 
            {
                if (guess < 1 || guess > 100) 
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                } 
                else if (guess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                } 
                else if (guess > magicNumber) 
                {
                    Console.WriteLine("Lower");
                } 
                else 
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            } 
            else 
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}