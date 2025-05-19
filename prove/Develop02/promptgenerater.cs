using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptList;
    private static Random _random = new Random(); 
    public PromptGenerator()
    {
      
        _promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_promptList.Count); 
        return _promptList[index];
    }
}