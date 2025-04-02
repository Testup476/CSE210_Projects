using System;
using Homework;

class Program
{
     
    static void Main(string[] args)
    {
        Assignment ass= new Assignment("Kanda Muamba","Addition");
        Console.WriteLine($"{ass.GetSummary()}");

        MathAssignment mathass = new MathAssignment("John Smith", "Multiplication", "3.6", "10-12");
        Console.WriteLine(mathass.GetSummary());
        Console.WriteLine(mathass.GetHomeWorkList());

        WritingAssignment write = new WritingAssignment("Lorence", "DRC History", "The war of The east Cost");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInfo());
    }
}