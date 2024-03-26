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
    }
}