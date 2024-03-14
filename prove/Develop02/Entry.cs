//The Entry class
using System;

public class Entry
{
//Create the attributes of the class
    public string _date;
    public string _prompt;
    public string _entryText;
    public string _location;

//Create the methods of the class
    public void EntryResponse()
    {
        //Get DateTime to string
        _date = DateTime.Now.ToShortDateString();
    }
}