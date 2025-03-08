using System;

class Program
{
    static void Main(string[] args)
    {
        var magic_number = new Random().Next(1, 10);
        int guess_number = 0;

        while (guess_number != magic_number)
        {
            Console.WriteLine("What is the guess number ?");
            guess_number = int.Parse(Console.ReadLine());
            if (magic_number > guess_number)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You geusse it !!");
            }
        }




    }
}
