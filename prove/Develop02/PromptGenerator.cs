using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        // adds new prompt in the list
        List<string> prompts = new List<string>();

            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("What challenge were you able to overcome today?");
            prompts.Add("What scripture verse from your personal study stood out to you today?");
        
        
        Random randomGenerator = new Random();
        int indexValue = randomGenerator.Next(prompts.Count);
        string randomString = prompts[ indexValue ];

        return randomString;
    }

}