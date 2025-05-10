using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num == 0)
                    break;
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            double total = numbers.Sum();
            double average = numbers.Average();
            double maximum = numbers.Max();

            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maximum}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}