public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {   
        DisplayRandomPrompt();
        Console.WriteLine();
        Console.Write("\nYou may begin in...");
        ShowCountDown(5);
    }

    public int GetCount()
    {
        return _count;
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
            
        Random randomGenerator = new Random();
        int indexValue = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[indexValue];

        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        return listFromUser;
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");
    }
   
}