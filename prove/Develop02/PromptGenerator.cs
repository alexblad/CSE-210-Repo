//The Prompt Generator class
using System;
using System.Collections.Generic;

public class PromptGenerator
{
//Creating the attributes of the class
    //Initialize the list when it is declared and
    //add the predefined prompts to the program
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What did you learn today? ",
        "Write about a challenge you encountered, and how you approached it. ",
        "What is a small act of kindness that you witnessed or performed today? ",
        "What goals have you been working towards recently? "
    };


//Creating the methods of the class
    //Randomly gets a prompt for the journal entry
    public string GetRandomPrompt()
    {
        Random random = new Random();
    }
}