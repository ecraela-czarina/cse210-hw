public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        numberToHide = random.Next(_words.Count);
        // System.Console.WriteLine("Test Scripture");
        _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        string verseString = " ";
        foreach (Word word in _words)
        {
            string wordString = word.GetDisplayText();
            verseString += (wordString);
            verseString += " ";
        }
        return ($"{_reference.GetDisplayText()} - {verseString}");
    }

    public bool IsCompletelyHidden()
    {
        string verseString = " ";
        foreach (Word word in _words)
        {
            string wordString = word.GetDisplayText();
            verseString += (wordString);
            verseString += " ";
        }
        
        if (verseString.Contains("_"))
        {
            return true;
        }

        else
        {
            return false;
        }
        
    }


}