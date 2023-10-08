public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        if (_isHidden == false)
        {
            int countLetters = _text.Count();
            // Console.WriteLine("Test 1");
            // Console.WriteLine($"{countLetters}");
            // Console.WriteLine("Test 2");
            // string charToRepeat = "_";
            string underscores = new string('_', countLetters);
            // Console.WriteLine($"hey {underscores}");
            _text = underscores;
        }
    
    }

    public void Show()
    {
        
    }

    public bool isHidden()
    {
        if (_text.Contains("_"))
        {
            _isHidden = true;
            return true;
        }

        else
        {
            _isHidden = false;
            return false;
        }
        
    }

    public string GetDisplayText()
    {
        string wordString = ($"{_text}");
        return wordString;
    }
}