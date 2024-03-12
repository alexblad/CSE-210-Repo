using System;

class Program
{
    static void Main(string[] args)
    {
        //Code for gettin user input for the 'magic number'
        //Console.WriteLine("What is your magic number? ");
        //string magic = Console.ReadLine();
        //int magNum = int.Parse(magic);

        //Code for random generation of the 'magic number'
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1,100);
        

        int newGuessNum;

        Console.WriteLine("Try to guess the magic number!");
        
        //Console.WriteLine(magNum);

        do
        {

            Console.WriteLine("What is your guess?");
            string newGuess = Console.ReadLine();

            newGuessNum = int.Parse(newGuess);


            if(newGuessNum == magNum)
            {
                Console.WriteLine("That's right!");
            }
            else if(newGuessNum > magNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        } while (magNum != newGuessNum );
    }
}