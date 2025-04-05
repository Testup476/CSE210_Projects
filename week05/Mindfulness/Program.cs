using System;
using MINDFULNESS;
class Program
{
    static void Main(string[] args)
    {
        int duration;

            Console.WriteLine("Welcome to the Mindfulness App");

            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Load Listing activity File");
            Console.WriteLine("5. Exit the program");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the duration (in seconds):");
                    duration = int.Parse(Console.ReadLine());
                    var breathingActivity = new BreathingActivity(duration);
                    breathingActivity.Run();
                    break;
                case 2:
                    Console.WriteLine("Enter the duration (in seconds):");
                    duration = int.Parse(Console.ReadLine());
                    var reflectingActivity = new ReflectingActivity(duration);
                    reflectingActivity.Run();
                    break;
                case 3:
                    Console.WriteLine("Enter the duration (in seconds):");
                    duration = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter how many items you want to list:");
                    int count = int.Parse(Console.ReadLine());
                    var listingActivity = new ListingActivity(duration, count);
                    listingActivity.Run();
                    break;
                case 4 : 
                    ListingActivity.LoadFile("Reflection.txt");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }    
    }
}