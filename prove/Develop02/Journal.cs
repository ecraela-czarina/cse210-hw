using System.IO;
using System.Collections.Generic;

public class Journal
{
    // public List<Entry> _entries;
    public List<Entry> _entries = new List<Entry>();
        
    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine("Entry Added");
        
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        
        // loop to iterate through each entry in the journal
        foreach (Entry entry in _entries)
        {
            
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
    
        using(StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                //input the "~~" to use it as a divider for each word in the file. 
                outputfile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
                
            }
        }
    }
    
    
    public void LoadToFile(string File)
    {
        
        string[] lines = System.IO.File.ReadAllLines(File);
        
        foreach (string line in lines)
        {

            // line format date~~prompt~~jounal entry
            string[] parts = line.Split("~~");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = entry;

            _entries.Add(newEntry);

        }
    }

}