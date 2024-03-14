//The Entry class
using System;

public class Entry
{
//Create the attributes of the class
    public string _date;
    public string _prompt;
    public string _entryText;
    public string _location;
    PromptGenerator _randprompt = new PromptGenerator();

//Create the methods of the class
    //Method to get the Entry Response
    public void EntryResponse()
    {
        //Get DateTime to string
        _date = DateTime.Now.ToShortDateString();
        //Welcome user to journal
        Console.WriteLine("Welcome to Your Journal");
        //Get the user's location
        Console.WriteLine("Where are you today?");
        _location = Console.ReadLine();
        //Get prompt for the entry 
        Console.WriteLine("Here is your prompt for today: ");
        _prompt = _randprompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        //Get entry text for the journal entry 
        _entryText = Console.ReadLine();
    }
    //Method to Display the EntryResponse
    public void DisplayEntry()
    {
        Console.WriteLine($"Entry from {_location} on {_date}");
        Console.WriteLine(_prompt);
        Console.WriteLine(_entryText);
    }
}