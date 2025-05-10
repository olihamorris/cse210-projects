using System;

class GradeConverrter
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage here? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";

        if (percent >= 97) 
        {
            letter = "A+";
        } 
        else if (percent >= 93) 
        {
            letter = "A";
        } 
        else if (percent >= 90) 
        {
            letter = "A-";
        } 
        else if (percent >= 87) 
        {
            letter = "B+";
        } 
        else if (percent >= 83) 
        {
            letter = "B";
        } 
        else if (percent >= 80) 
        {
            letter = "B-";
        } 
        else if (percent >= 77) 
        {
            letter = "C+";
        } 
        else if (percent >= 73) 
        {
            letter = "C";
        } 
        else if (percent >= 70) 
        {
            letter = "C-";
        } 
        else if (percent >= 67) 
        {
            letter = "D+";
        } 
        else if (percent >= 63) 
        {
            letter = "D";
        } 
        else if (percent >= 60) 
        {
            letter = "D-";
        } 
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 60) 
        {
            Console.WriteLine("You passed!");
        } 
        else 
        {
            Console.WriteLine("You failed. Try harder next time!");
        }
    }
}