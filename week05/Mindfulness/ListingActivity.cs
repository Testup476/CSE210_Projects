
namespace MINDFULNESS;

public class ListingActivity : Activity
{
    public string question { get; set; }

    protected int _count { get; set; }
    protected ReflectingActivity reflection;

    public static List<string> _prompts = new List<string>()
    {"Who are people you appropriate ? ",
    " What are personal strengths of yours ? ",
    "What are people that you have helped ?"};
    public static List<string> Items = new List<string>();

    Random random = new Random();

    public ListingActivity(int duration, int count)
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = count;
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(_duration);
        GetRamdomPrompt();
        GetListFromUser();

        Console.WriteLine("Would you like to save this actitity ? (y/n)");
        string key = Console.ReadLine();
        if (key.ToLower() == "y")
        {
            SaveFile("Reflection.txt");
        }
        else if (key.ToLower() == "n")
        {
            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Program stoped..");
            Environment.Exit(0);
        }

    }


    public void GetRamdomPrompt()
    {
        int index = random.Next(_prompts.Count());
        string prompt = _prompts[index];
        question = prompt;
        Console.WriteLine($"{prompt}");
    }

    public List<string> GetListFromUser()
    {
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            System.Console.WriteLine("Enter an item (or type 'done' to stop): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break;
            }
            Items.Add(item);
        }
        Console.WriteLine("Your List is :");
        foreach (var item in Items)
        {
            System.Console.WriteLine($"{item}");
        }
        return Items;
    }

    // Method to save the Reflecting Activity in the File

    public void SaveFile(string Filename)
    {
        using (StreamWriter file = new StreamWriter(Filename))
        {
            file.WriteLine($" Date and Time : {DateTime.Now}");
            file.WriteLine($"Question : {question}");
            file.WriteLine($"Duration : {_duration} seconds");
            file.WriteLine("Answears :");
            foreach (var items in Items)
            {
                file.WriteLine($"{items}");

            }
            Console.WriteLine("File saved ...");
        }
    }
    // Methode for Loading the File
    public static void LoadFile(string filename)
    {
        string[] Lines = System.IO.File.ReadAllLines(filename);

        foreach (var item in Lines)
        {
            Console.WriteLine(item);
        }
    }
}