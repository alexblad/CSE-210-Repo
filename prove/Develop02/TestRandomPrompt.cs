 //Test the GetRandomPrompt
public class Test
{
    public static void TestOutput()
    {
    //Instantiates the class
        PromptGenerator _randomprompt = new PromptGenerator();
    
    //Get a random prompt
        string prompt = _randomprompt.GetRandomPrompt();
        Console.WriteLine($"Random Prompt: {prompt}");
    }
}