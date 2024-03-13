//The Job class

public class Job
{
    //Creating the attributes of the class
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Creating class DisplayInfo method
    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle } ({_companyName}) {_startYear}-{_endYear}");
    }
}