using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your firstname?");
        string Firstname = Console.ReadLine();

        Console.WriteLine("What is your lastname?");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {Firstname}, {lastname}");
    }
}