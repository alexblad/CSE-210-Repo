using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        do 
        {
    

            journal.DisplayOptions();
            Console.WriteLine("What would you like to do? (Pick from 1-5)");
            choice= int.Parse(Console.ReadLine());

        
            if(choice == 1)
            {
                journal.NewEntry();
            }
            else if(choice == 2)
            {
                journal.DisplayEntries();
            }
            else if(choice == 3)
            {
                Console.WriteLine("What is your journal's file name?");
                string jFile = Console.ReadLine();
                journal.LoadFromFile(jFile);
            }
            else if(choice == 4)
            {
                Console.WriteLine("What would you like to save your file as? (Must be a .txt file)");
                string jFile = Console.ReadLine();
                journal.SaveToFile(jFile);
            }
            else if(choice == 5)
            {
                journal.Quit();
            }
            else 
            {
                Console.WriteLine("Please enter 1-5!");
            }
        }while(choice != 5);




        //Test the RandomPromptGenerator
        //Test.TestOutput();

    
    }
}