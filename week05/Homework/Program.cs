using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Martin Luther", "Algebraic Equations");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Rob Hector", "Measuration", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Merriman Diop", "African History", "The Fall of Somghai Empire");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}