using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptList;
    private static Random _random = new Random(); // Static Random instance for better performance

    public PromptGenerator()
    {
        // Initialize the list of prompts
        _promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        int index = _random.Next(_promptList.Count); // Generate a random index
        return _promptList[index]; // Return the prompt at the random index
    }
}