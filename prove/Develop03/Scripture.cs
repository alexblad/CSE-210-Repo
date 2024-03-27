using System.Text;

public class Scripture 
{
//Attributes
    private Reference _reference; 
    private List<Word> _words;
    private bool _allHidden; 

//Methods
    //Constructors
    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = CreateWordList(words);
        _allHidden = false;


    }

    //Other methods
    private List<Word> CreateWordList(string words)
    {
        List<Word> scriptureWords = new List<Word>();
        string[] wordArray = words.Split(new char[] {' ', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            scriptureWords.Add(word);
        }
        return scriptureWords;
    }

    public void HideWords(int numberToHide)
    {
        //Check if numberToHide is valid
        if (numberToHide <= 0 || numberToHide > _words.Count)
        {
            throw new ArgumentException("Invalid number of words to hide.");
        }

        //Create a list of indeces for the words in the verse
        List<int> indicesToHide = new List<int>();

        Random random = new Random();
        while (indicesToHide.Count < numberToHide)
        {
            int indexOfHidden = random.Next(_words.Count);
            if (!_words[indexOfHidden].isHidden() && !indicesToHide.Contains(indexOfHidden))
            {
                indicesToHide.Add(indexOfHidden);
            }
        }

        foreach(int index in indicesToHide)
        {
            _words[index].Hide();
        }
    }
    //Getters
    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var word in _words)
        {
            sb.Append(word.GetDisplayText());
            sb.Append(" "); //Add space between words

        }
        return ($"{_reference.GetDisplayText()} {sb.ToString()}");

    }

    public bool AreAllHidden()
    {
        foreach(var word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return _allHidden = true;
    }

    public bool IsHidden()
    {
        return _allHidden;
    }

    
}