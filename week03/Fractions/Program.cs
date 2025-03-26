using System;
using Fractions;

class Program
{
    public static readonly Fraction f1 = new Fraction();
    public static readonly Fraction f2 = new Fraction(5);
    public static readonly Fraction f3 = new Fraction(3, 4);

    public static readonly Fraction f4 = new Fraction(1, 3);
    static void Main(string[] args)
    {
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

        // For the fraction with a parameter 
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");

        // For the fraction with 2 paramaeters

        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");

        // 

        Console.WriteLine($"{f4.GetFractionString()}");
        Console.WriteLine($"{f4.GetDecimalValue()}");
    }
}