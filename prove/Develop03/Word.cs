public class Word
{
//Attributes 
    private string _text;
    private bool _isHidden;
    private string _hiddenText;
    

//Methods 
    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false; //Word is not initially hidden
        _hiddenText = ""; //No hidden text initially
    }

    //Getters 
    public string GetDisplayText() //Returns text to be displayed
    {
        if (_isHidden) //Default in C# is to check for condition to be true so I do not specify _isHidden == true
        {
            foreach(char letter in _text)
            {
                return new string('_', _text.Length);
            }
            return _hiddenText;
        }
        else
        {
            return _text; 
        }
    }

    //Other Methods
    public bool isHidden()
    {
        return _isHidden; //Returns bool true/fales for _isHidden
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
        _hiddenText = ""; //Reset hidden text
    }
}