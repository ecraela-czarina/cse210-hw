public class GoalManager
{

    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
       Console.WriteLine($"You have {_score} points");
    }

    public void DisplayPlayerInfo()
    {
        
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            goal.GetDetailsString();
        }
    }


    public void AddGoal(Goal newGoal)
    {
        Console.WriteLine("Goal Added");
        
        _goals.Add(newGoal);

        // Console.WriteLine("The types of goals are:");
        // Console.WriteLine("     1. Simple Goal");
        // Console.WriteLine("     2. Eternal Goal");
        // Console.WriteLine("     3. Checklist Goal");
        // Console.Write("Which type of goal would you like to create? ");
        // string goalType = Console.ReadLine();

        // if (goalType == "1")
        // {
        //     SimpleGoal sg = new SimpleGoal();//(shortName, description, points, false);
        //     Console.WriteLine(sg);
        //     _goals.Add(sg);
        // }

        // else if (goalType == "2")
        // {
        //     EternalGoal eg = new EternalGoal();//(shortName, description, points);
        //     _goals.Add(eg);
        // }

        // else (goalType == "3");
        // {
        //     ChecklistGoal cg = new ChecklistGoal();//(shortName, description, points, 0, target);
        //     _goals.Add(cg);
        // }
    }

    public void RecordEvent()
    {

    }

    // public void SaveGoals()
    // {
    //     using(StreamWriter outputfile = new StreamWriter(file))
    //     {
    //         foreach (Goal goal in _goals)
    //         {
    //             //input the "~~" to use it as a divider for each word in the file. 
    //             outputfile.WriteLine($"{goal._shortName}~~{goal._description}~~{goal._points}");
                
    //         }
    //     }
    // }

    // public void LoadGoals()
    // {
    //     string[] lines = System.IO.File.ReadAllLines(File);
        
    //     foreach (string line in lines)
    //     {

    //         // line format date~~prompt~~jounal entry
    //         string[] parts = line.Split("~~");

    //         string shortName = parts[0];
    //         string description = parts[1];
    //         string points = parts[2];

    //         Goal newGoal = new Goal();
    //         newGoal._shortName = shortName;
    //         newGoal._description = description;
    //         newGoal._points = points;

    //         _goals.Add(newGoal);

    //     }
    // }
}