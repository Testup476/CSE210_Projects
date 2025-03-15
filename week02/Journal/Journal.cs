
using journal;

namespace JOURNAL;

public class Journal
{
    public static List<Entry> _entries = new List<Entry>();
    public static List<string> prompts = new List<string>()
    { "What is your favorite chapter in the bible ?",
        "Wat is your favorite name in the bible ?",
         "What can you do when facing a problem ?",
        "What is the most beautiful thing you do in your familly",
        "Say something about procratination"
        };

    public static Random random = new Random();
    public static void AddEntry(Entry newEntry)
    {

        int randomindex = random.Next(prompts.Count());
        string prompt = prompts[randomindex];
        Console.WriteLine(prompt);
        string answear = Console.ReadLine();

        newEntry._prompText = prompt;
        newEntry._entryText = answear;
        newEntry._date = DateTime.Now.ToString();
        _entries.Add(newEntry);

    }


    public static void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry._date} : {entry._prompText}");
            Console.WriteLine($"{entry._entryText}");
        }
    }

    public static void SaveTofile(string file)
    {
        using (StreamWriter infile = new StreamWriter(file))
        {
            foreach (var items in _entries)
            {
                infile.WriteLine($"{items._date} : {items._prompText}");
                infile.WriteLine($"{items._entryText}");
            }
        }
        Console.WriteLine($"Saved to : {file}");
    }


    public static void LoadFromFile(string file)
    {
        string[] Lines = System.IO.File.ReadAllLines(file);


        foreach (var items in Lines)
        {
            Console.WriteLine(items);
        }
    }

}