public class BreathingActivity : Activity
{
    

    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        // The Breathing activity used is the 4-7-8 which helps calms anxiety
        Console.WriteLine();
        Console.Write("\nBreathe in...");
        ShowCountDown(4);
        Console.Write("\nHold your breath...");
        ShowCountDown(7);
        Console.Write("\nNow exhale...");
        ShowCountDown(8);
        Console.WriteLine();
        
        Thread.Sleep(1000);
    }


   
}