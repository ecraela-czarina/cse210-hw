using System;

class Program
{
    static void Main(string[] args)
    {
        string initialAction = "";
        while (initialAction != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflecting Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Quit");

            Console.Write("Select a choice from the menu: ");
            string action = Console.ReadLine();

            if (action == "1")
            {
                string activityName = "Breathing Activity";
                string activityDescription = "This activity will help you relax by walking through your breathing in and out slowly. \n Clear your mind and focus on your breathing.";
                // string activityDescription = "Test 1";

                BreathingActivity breathe = new BreathingActivity(activityName, activityDescription);

                breathe.DisplayStartingMessage();
                
                
                Console.Write("How long, in seconds, would you like your session? [The minimum is 15 Seconds]:");
                string userInput = Console.ReadLine();
                int secondsInput = int.Parse(userInput);
                breathe._duration = secondsInput;

                // Console.WriteLine($"{secondsInput}");
                int repeat = secondsInput / 15;
                Console.Clear();
                Console.WriteLine("Get Ready...");
                Console.WriteLine("This is the 4-7-8 Breathing Activity");
                breathe.ShowSpinner(1000);

                for (int i = 0; i < repeat; i++) 
                {
                    breathe.Run();
                    
                }
                
                // breathe.DisplayEndingMessage();
                Console.WriteLine("Well done!");
                breathe.DisplayEndingMessage();
                Console.WriteLine("Redirecting you... Please wait.");
                breathe.ShowSpinner(1000);
                Console.Clear();


            }

            else if (action == "2")
            {
                string activityName = "Reflecting Activity";
                string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This help you recognize the power you have and how you can use it in other aspects of your life.";
                // string activityDescription = "Test 1";
                

                ReflectingActivity reflect = new ReflectingActivity(activityName, activityDescription);
                reflect.DisplayStartingMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like your session? [The minimum is 15 Seconds]:");
                string userInput = Console.ReadLine();
                int secondsInput = int.Parse(userInput);
                reflect._duration = secondsInput;

                

                int repeat = secondsInput / 15;
                Console.Clear();
                Console.WriteLine("Get Ready...");
                
                reflect.ShowSpinner(1000);
                
                Console.WriteLine("Consider the following Prompt:");
                Thread.Sleep(1000);
                reflect.DisplayPrompt();
                Console.WriteLine();
                Console.WriteLine("When you have something in mind, enter to continuue: ");
                string actionInput = Console.ReadLine();
                
                Console.WriteLine("You may ponder on each of the following questions as they relate to this experience:  ");
                reflect.Run();
                Console.Clear();

                for (int i = 0; i < repeat; i++) 
                {
                    reflect.DisplayQuestion();
                    reflect.ShowSpinner(5000);
                        
                }
                
                
                Console.WriteLine("Well done!");
                reflect.DisplayEndingMessage();
                Console.WriteLine("Redirecting you... Please wait.");
                reflect.ShowSpinner(1000);
                Console.Clear();
                
            }

            else if (action == "3")
            {
                string activityName = "Listing Activity";
                string activityDescription = "This activity will help you reflect on the good things of your life \n by having you list as many things as you can in a certain area.";
                

                ListingActivity listing = new ListingActivity(activityName, activityDescription);
                listing.DisplayStartingMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like your session? [The minimum is 15 Seconds]: ");
                string userInput = Console.ReadLine();
                int secondsInput = int.Parse(userInput);
                listing._duration = secondsInput;

                

                int repeat = secondsInput / 15;
                Console.Clear();

                Console.WriteLine("Get Ready...");
                
                listing.ShowSpinner(1000);
                // listing.DisplayRandomPrompt();
                // listing.Run();

                List<string> fromUser = new List<string>();
                string listFromUser = "";
                while (listFromUser != "quit")
                {
                    // listing.Run();
                    string userList = Console.ReadLine();

                    if (userList != "")
                    {
                        fromUser.Add(userList);
                    }

                    else if (userList == "")
                    {
                        listFromUser = "quit";
                    }
                    
                }

                int listCount = fromUser.Count();
                Console.WriteLine($"You listed {listCount} items!");

                Console.WriteLine("Well done!");
                listing.DisplayEndingMessage();
                Console.WriteLine("Redirecting you... Please wait.");
                listing.ShowSpinner(1000);
                Console.Clear();

          
            }

            else if(action == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program")
                initialAction = 4;
            }
        }
        
        
    }
}