using System;

class Program
{
    static void Main(string[] args)
    {
        
        // this code adds a new object to the Goal Class
        GoalManager goalManager = new GoalManager();

        string initialAction = " ";
             


        while (initialAction != "5" ) 
        {
            goalManager.Start();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Events");
            Console.WriteLine("     6. Quit");

            Console.Write("Select a choice from menu: ");
            string action = Console.ReadLine();


            if (action == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                
                
                if (goalType == "1")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();

                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                    goalManager.AddGoal(simpleGoal);
                    initialAction = " ";
                    

                }

                if (goalType == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();
                    

                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints );
                    goalManager.AddGoal(eternalGoal);
                    initialAction = " ";
                    

                }

                if (goalType == "3")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();
                    Console.WriteLine("How many times would you like to complete this goal? ");
                    int goalTarget = int.Parse(Console.ReadLine());

                    // ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, 0, goalTarget);
                    // goalManager.AddGoal(checklistGoal);
                    // initialAction = " ";
                    

                }
                
            }

            else if (action == "2")
            {
                Console.WriteLine("The Goals are: ");
                goalManager.ListGoalDetails();
            }

        }
    }
}