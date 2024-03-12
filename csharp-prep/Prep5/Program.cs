using System;

class Program
{
    static void Main(string[] args)
    {
    
        DisplayWelcome();
        string name =PromptUserName();
        int favnum = PromptUserNumber();
        int squareNum = SquareNumber(favnum);
        DisplayResult(name, squareNum);

    }

    //Displays the welcome to the Program
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    //Prompts the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //Prompts the user for a number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum = int.Parse(Console.ReadLine());
        return favnum;
    }

    //Calculates the square of the number given by the user
    static int SquareNumber(int favnum)
    {
        int squareNum = favnum * favnum; 
        return squareNum;
    }

    //Displays the result of the number being squared 
    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is: {squareNum}");
    }
}