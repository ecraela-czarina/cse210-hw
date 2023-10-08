using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        // [STRETCH] I added an option where the user can choose a verse to memorize.
        Reference verseReference1 = new Reference("Proverbs", 3, 5, 6);                    
        Scripture scriptureVerse1 = new Scripture(verseReference1, "Trust in the Lord with all thine heart … and he shall direct thy paths.");
        

        Reference verseReference2 = new Reference("John", 17, 3);                    
        Scripture scriptureVerse2 = new Scripture(verseReference2, "And this is life eternal, that they might know thee the only true God, and Jesus Christ.");
        
        

        string initialAction = "";

        // While the user input != quit(Look at previous while)
        while (initialAction != "quit")
        {
            Console.WriteLine("Please Choose a verse or an Action:");
            Console.WriteLine("1. Proverbs 3: 5-6");
            Console.WriteLine("2. John 17:3");
            Console.WriteLine("3. Quit");
            string userInput = Console.ReadLine();
            

            if (userInput == "1")
            {
                Console.WriteLine(scriptureVerse1.GetDisplayText());
                string action = "";
                while (action != "exit")
                {
                    Console.WriteLine("Press enter to continue or type 'exit' to return to homepage when done");
                    string userAction = Console.ReadLine();
                    if (userAction == "")
                    {
                        Console.WriteLine(scriptureVerse1.GetDisplayText());
                        scriptureVerse1.HideRandomWords(4);
                        Console.WriteLine(scriptureVerse1.GetDisplayText());
                        // Console.WriteLine("Test 1");
                    }

                    if (userAction == "exit")
                    {
                        action = "exit";
                    }
                    
                }
            }
            if (userInput == "2")
            {
                Console.WriteLine(scriptureVerse2.GetDisplayText());
                string action = "";
                while (action != "exit")
                {
                    Console.WriteLine("Press enter to continue or type 'exit' to return to homepage when done");
                    string userAction = Console.ReadLine();
                    if (userAction == "")
                    {
                        // Console.WriteLine(scriptureVerse2.GetDisplayText());
                        scriptureVerse2.HideRandomWords(4);
                        Console.WriteLine(scriptureVerse2.GetDisplayText());
                        // Console.WriteLine("Test 1");
                    }

                    if (userAction == "exit")
                    {
                        action = "exit";
                    }
                    
                }
                
                
            }

            else if (userInput == "3")
            {   
                Console.WriteLine("Thank you for using the program!");
                initialAction = "quit";
            }

        }
        
    }
}