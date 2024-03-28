public class MathAssignment : Assignment
{
//Child class of Assignment
    //Attributes
    private string _section;
    private string _probs;

//Methods 
    //Constructors 
    public MathAssignment(string student, string topic, string section, string problems)
        : base(student, topic)
        {
            _section = section;
            _probs = problems;
        }
    
    public MathAssignment() : base()
    {
        _section = "Unknown";
        _probs = "Unkown";
    }

    //Getters
    public string GetSection()
    {
        return _section;
    }

    public string GetProbl()
    {
        return _probs;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_probs}";
    }

}