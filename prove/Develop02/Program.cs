using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        //Test the RandomPromptGenerator
        //Test.TestOutput();
        
        DateTime date = DateTime.Now;
        string shortDate = date.ToShortDateString();
        Console.WriteLine(shortDate);
        
    }
}