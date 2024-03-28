public class WritingAssignment : Assignment
{
//Attributes 
    private string _title;

//Methods 
    //Constructors
    public WritingAssignment(string student, string topic, string title) 
        : base(student, topic)
        {
            _title = title;
        }

    public WritingAssignment() : base()
    {
        _title = "Unkown";
    }

    //Getters
    public string GetTitle()
    {
        return _title;
    }

    public string GetWritingInformation() 
    {
        string auth = GetStudentName();
        return $"{_title} by {auth}";
    }
}