using System;

class Program
{
    static void Main(string[] args)
    {
       GoalManager manager = new();
        string file = "goals.txt";

        while (true)
        {
            Console.WriteLine("\n--- Goal Tracker ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.DisplayGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.ShowScore(); break;
                case "5": manager.SaveGoals(file); break;
                case "6": manager.LoadGoals(file); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}