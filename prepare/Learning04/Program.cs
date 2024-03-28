using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a base Assignment
        Assignment a1 = new Assignment("Alex Jones", "Derivatives");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        //Create Derived Assignmets

        MathAssignment a2 = new MathAssignment("Billy Joe", "Subtraction", "1.4", "9-24");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "American History", "Why the USS Texas is the GOAT");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        Console.WriteLine();

        
    }
}