using System;

class Program
{
    static void Main(string[] args)
    {
        Word w1 = new Word("bigboy");
        w1.GetDisplayText();
        Console.WriteLine(w1.GetDisplayText());

        w1.Hide();
        Console.WriteLine(w1.GetDisplayText());

        w1.Show();
        Console.WriteLine(w1.GetDisplayText());


        Reference v1 = new Reference("Nephi", 1, 5);
        Reference v2 = new Reference("James", 1, 6, 9);

        Console.WriteLine(v1.GetDisplayText());
        Console.WriteLine(v2.GetDisplayText());

//Get initial coniditions for the program
        string newverse = "yes";

        while (newverse.ToLower() == "yes")
        {
            Console.WriteLine("What book is your scripture in?");
            string book= Console.ReadLine();
            Console.WriteLine("What chapter?");
            int chapt = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the starting verse?");
            int verse1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the end verse?");
            int verse2 = int.Parse(Console.ReadLine());
            Reference newRef;
            if (verse1 == verse2)
            {
                newRef = new Reference(book, chapt, verse1);
            }
            else
            {
                newRef = new Reference(book, chapt, verse1, verse2);
            }
            Console.WriteLine("What does the scripture say?");
            string words = Console.ReadLine();
            Scripture toMemorize = new Scripture(newRef, words);

            Console.WriteLine(toMemorize.GetDisplayText());

            Random random = new Random();
            int randomToHide = random.Next(1,3);
            toMemorize.HideWords(randomToHide);

            Console.WriteLine(toMemorize.GetDisplayText());
        }
        Console.WriteLine("Would you like to try a new verse?");
        newverse = Console.ReadLine();

    }
}