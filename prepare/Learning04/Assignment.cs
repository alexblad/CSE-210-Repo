public class Assignment
{
//The Parent class
//Attributes
    private string _studentName;
    private string _topic;

//Methods 
    //Constructors

    public Assignment()
    {
        _studentName = "Anonymous";
        _topic = "Unknown";
    }

    public Assignment (string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    //Getters
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}   