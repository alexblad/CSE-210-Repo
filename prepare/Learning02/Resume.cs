//The Resume class

public class Resume
{
    //Creating the attributes of the class
    public string _name; //First and last
    
    //Initialize the list when it is declared
    public List<Job> _jobs = new List<Job>();

    //Create a method to display the details of the ._jobs
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        
        //Goes through each Job class in the list and calls the DisplayInfo() function for
        //the Job class in the list
        foreach(Job job in _jobs)
        {
            job.DisplayInfo();
        }
    }

}
