using System;
using System.IO; 
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        string initialAction = " ";
        // this code generates a random prompt for the journal entry    
        PromptGenerator pg = new PromptGenerator();
        // this code adds a new object to the Journal Class
        Journal newJournal = new Journal();


        //[STRETCH] automatically loads from file. From what I've noticed, if the entries was not loaded from file,
        //when user saves it, it will overwrite whaterver is in that file. 
        //to avoid that, I added this code.
        newJournal.LoadToFile("journal.txt");


        while (initialAction != "5" ) 
        {
            Console.WriteLine("Please Select One of the Following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string action = Console.ReadLine();

            
            
            // if the user chose "write"
            if (action == "1")
            {
                string prompt = pg.GetRandomPrompt();
                Console.WriteLine(prompt);
                
                string response = Console.ReadLine();
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToString("dddd, dd MMMM yyyy hh:mm tt");
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                initialAction = " ";
                // appends the entry to the list of entries in the journal class
                newJournal.AddEntry(newEntry);
            }

            // if the user chose "display"
            else if (action == "2")
            {
                Console.WriteLine("Here are your journal entries");
                newJournal.DisplayAll();
                initialAction = " ";
            }

            // if the user chose "load"
            else if( action == "3")
            {
                Console.WriteLine("What is the filename?");
                string response = Console.ReadLine();

                newJournal.LoadToFile(response);
                Console.WriteLine("Loading from file...");
                Console.WriteLine("File loaded!");
                initialAction = " ";

            }
            
            // if the user chose "save"
            else if(action == "4")
            {

                Console.WriteLine("What is the filename?");
                string response = Console.ReadLine();
               

                newJournal.SaveToFile(response);
                Console.WriteLine("Saving to file...");
                Console.WriteLine("File saved!");
                initialAction = " ";
            }
            
            // if the user chose "quit"
            else if (action == "5")
            {
                 Console.WriteLine("Thank you for writing in your journal today!");
                 initialAction = "5";
            }

            
            
        } 
    }
}