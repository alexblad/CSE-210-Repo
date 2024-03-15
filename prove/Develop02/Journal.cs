//The Journal Class
using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{
//Creating the attributes of the class
    //Initialize the list of menu options
    //add predefined menu options to the list
    public List<string> _menuOptions = new List<string>
    {
        "----------Options-----------",
        "----------------------------",
        "1. Write",
        "2. Read Journal",
        "3. Load Journal", 
        "4. Save Journal", 
        "5. Quit",
        "----------------------------"
    };

    //Initialize the list of journal entries
    public List<Entry> _entries = new List<Entry>();

//Create the methods of the class
    //Create a new entry 
    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.EntryResponse();
        //entry.DisplayEntry();
        _entries.Add(entry);
    }

    //Display all the entries
    public void DisplayEntries()
    {
        //Checks whether there is an entry or not yet
        if(_entries.Count() != 0)
        {
            foreach(Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }
        //If there are no entries, prompt the user to start writing
        else
        {
            Console.WriteLine("There are no entries yet! Better get writing...");
            int numentry = _entries.Count();
            Console.WriteLine(numentry);
        }
    }

    //Method to save journal to a file
    public void SaveToFile(string filename)
    {
        //Check if there are entries before saving
        if (_entries.Count == 0)
        {
            Console.WriteLine("Cannot save an empty journal.");
            return; 
        }
        //If there are entries, save the file
        using(StreamWriter writer = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("File saved succesfully.");

    }

    //Method to load the journal from a file
    public void LoadFromFile(string filename)
    {
        //Clear any existing entries
        _entries.Clear();
        //Read from a specified file
        using(StreamReader reader= new StreamReader(filename))
        {
        //Load entries
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Entry entry = new Entry();
                string[] parts = line.Split("|");
                entry._date = parts[0];
                entry._location = parts[1];
                entry._prompt = parts[2];
                entry._entryText = parts[3];
                _entries.Add(entry);
            }   
        }
    }

    public void DisplayOptions()
    {
        foreach( string option in _menuOptions)
        {
            Console.WriteLine(option);
        }
    }

    public void Quit()
    {   
        Console.WriteLine("----------------------");
        Console.WriteLine("Exiting the program...");
        Console.WriteLine(" Have a wonderul day! ");
        Console.WriteLine("----------------------");
    }
}