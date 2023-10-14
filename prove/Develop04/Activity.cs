public class Activity
{
    protected string _name;
    protected string _description;
    public int _duration;

    public Activity (string name, string description)
    {
        _name = name;   
        _description = description;
        
    } 

   
    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine($"Description: {_description}");
           
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have Completed {_duration} seconds of {_name}");
        Thread.Sleep(2000);
        
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}