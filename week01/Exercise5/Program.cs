using System;

class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static string PromptUserName()
    {
        Console.WriteLine("Please enter your name : ");
        string username = Console.ReadLine();
        return username;
    }

    public static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number :");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }
    public static int SquarteNumber(int number)
    {
        return number *= number;
    }

    public static void DisplayResult(string username, int SquarteNumber)
    {
        Console.WriteLine($"{username}, the square of your number is {SquarteNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int Squartenumber = SquarteNumber(number);
        DisplayResult(name, Squartenumber);


    }
}