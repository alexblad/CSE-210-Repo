public class Reference
{
//Attributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _manyVerses;

//Methods 
    //Constructors
    public Reference(string book, int chapter, int verse) //Constructer for just 1 verse
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _manyVerses = false;
    }

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
        _manyVerses = true;
    }

    //Getters
    public string GetDisplayText()
    {
        if(_manyVerses == true)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }

}