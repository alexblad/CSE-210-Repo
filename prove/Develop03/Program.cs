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
    }
}