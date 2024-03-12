using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? (type the percentage as a number ex. 90)");
        string grade = Console.ReadLine();

        int gradenum = int.Parse(grade);
        
        string letter="";

        if (gradenum>=90)
        {
            //Console.WriteLine("You have and A.");
            letter = "A";
        }
        else if (gradenum<=89 && gradenum>=80)
        {
            //Console.WriteLine("You have a B.");
            letter = "B";
        }
        else if (gradenum<=79 && gradenum>=70)
        {
            //Console.WriteLine("You have a C.");
            letter = "C";
        }
        else if (gradenum<=69 && gradenum>=60)
        {
            //Console.WriteLine("You have a D.");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("You have and F.");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (gradenum>=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}