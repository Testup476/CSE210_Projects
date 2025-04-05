namespace MINDFULNESS;

public class Activity
{
    protected string _name { get; set; }
    protected string _description{get;set;}
    protected int _duration { get; set; }

    public Activity(string name, string description, int duration)
    {
        _name=name;
        _description=description;
        _duration=duration;
    }

    public void DisplayStartingMessage()
    {
        //Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area");
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Please set the duration (in seconds)");
        _duration=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin the Activity...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You've completed the {_name} Activity");
        Console.WriteLine($"duration : {_duration} seconds");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>() { ".", "..", "..." };
        for (int i = 0; i < seconds; i++)
        {
            foreach (var item in spinner)
            {
                Console.Write(item);
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
       
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    
}