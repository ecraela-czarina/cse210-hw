public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        
        Console.WriteLine();
        Console.Write("\nYou may begin in...");
        ShowCountDown(5);
        
    }

    public string GetRandomPrompt()
    {
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
            
        Random randomGenerator = new Random();
        int indexValue = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[indexValue];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
            
        Random randomGenerator = new Random();
        int indexValue = randomGenerator.Next(_questions.Count);
        string randomQuestion = _questions[ indexValue ];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"{GetRandomQuestion()}");
    }
}

