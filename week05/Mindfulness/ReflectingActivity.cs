using System;

namespace MINDFULNESS;

public class ReflectingActivity: Activity
{
    Random rd= new Random();
    
    public ReflectingActivity (int duration) 
    :base("Reflection activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",duration)
    {
    }
    List<string> _prompts = new List<string>()
    {"Think of a time when you stood up for some one else",
    "Think of a time when you did something really difficult",
    "Think of a time when you helped someone need",
    "Think of a time when you did something truly selfness"
    };
    List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you ?",
        "Have you ever done anything like this before ?",
        "How did you get started ?",
        "How did you feel when it was complete ?",
        "What made this time different than other times when you were not successful ?",
        "What could you learn from this experence that applies to other situations ?",
        "What did you learn about yourself through this experence ?",
        "How can you keep this experience in mind in the future ?"
    };
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"{GetRandomPrompt()}");
        ShowCountDown(5);
        DateTime endTiem=DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTiem)
        {
            Console.WriteLine($"{GetRandomQuestion()}");
            ShowCountDown(10);
        }

        DisplayEndingMessage();
    }
     public string GetRandomPrompt()
    {
        int index = rd.Next(_prompts.Count());
        string prompt = _prompts[index];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        int index = rd.Next(_questions.Count());
        string _question = _questions[index];
        return _question;
    }

}