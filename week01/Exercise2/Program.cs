using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percent ?");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = " Your grade is A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = " Your grade is B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = " Your grade is C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = " Your grade is D";
        }
        else
        {
            letter = " Your grade is F";
        }
        Console.WriteLine($"Your letter grade is : {letter}");
        

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation ! You passed the course");
        }
        else
        {
            Console.WriteLine("Keep trying until you make better");
        }

    }
}