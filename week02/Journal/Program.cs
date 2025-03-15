using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using journal;
using JOURNAL;

class Program
{
    static void Main(string[] args)
    {
        int choice = 1;


        while (choice != 0 && choice > 0)
        {
        Menu:
            Console.WriteLine("Please Chose one of the following :");
            Console.WriteLine("-------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("-------");
            string input = Console.ReadLine();
            if (input == null || !int.TryParse(input, out choice))
            {
                Console.WriteLine("Please select a number!");
                choice = 1;
                goto Menu;
            }

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry();
                    Journal.AddEntry(entry);
                    break;
                case 2:
                    Journal.DisplayAll();
                    break;
                case 3:
                    Journal.SaveTofile("Entry.txt");
                    break;
                case 4:
                    Console.WriteLine("Enter the file name :");
                    string filename = Console.ReadLine();
                    Journal.LoadFromFile(filename);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}