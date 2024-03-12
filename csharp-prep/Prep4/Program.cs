using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        int newNum;
        List <int> numbers = new List<int>();

        do
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            newNum = int.Parse(number);

            //Will exclude 0 from the list of numbers
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }

        } while (newNum != 0);

        //Prints the numbers in the list
        //foreach (int number in numbers)
        //{
        //    Console.Write($"{number} ");
        //}

        int N = numbers.Count();

        float sum = numbers.Sum();

        float avg = sum/N;

        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");


    }
}