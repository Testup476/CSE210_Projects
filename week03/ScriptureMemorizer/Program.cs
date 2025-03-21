using System;
using System.Xml.Schema;
using ScriptureMemorizer;

class Program
{
    public static readonly Reference _ref = new Reference("Proverbd", 3, 5, 6);
    public static readonly Scripture script = new Scripture(_ref, "Trust in the Lord with all your heart, and lean not on you own understanding. In all your ways acknowledge Him, and he shall direct your paths");

    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.Clear();
            Console.WriteLine(_ref.GetDisplayText());
            Console.WriteLine(script.GetDisplayText());

            if (script.IsCompletelyHidden())
            {
                Console.WriteLine("The scripture is completely hidden!");
                break;
            }

            Console.WriteLine("Press 'Enter' to hide more words, or type 'quit' to exit.");
            input = Console.ReadLine();
            if (input.ToLower() != "quit")
            {
                script.HideRandomwords(3);
            }
        } while (input.ToLower() != "quit");
    }
}
