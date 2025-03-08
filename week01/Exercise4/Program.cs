using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>();

        int sum = 0;
        int number = -1;
        float Avarage;
        while (number != 0)
        {
            Console.WriteLine("Enter number : ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                list.Add(number);
            }

        }
        foreach (int i in list)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is {sum}");
        // Compute the Avarage 

        int list_size = list.Count();
        Avarage = ((float)sum) / list_size;
        Console.WriteLine($"The Avarage is {Avarage}");

        //Find the larget number
        int largest_number = list[0];
        foreach (int i in list)
        {
            if (largest_number < i)
            {
                largest_number = i;
            }
        }
        Console.WriteLine($"The Largest number is {largest_number}");
        //Stretch Challenge
        // 1. Finding the smallestpositive number
        var smallestpositive = list.Where(n => n > 0).Min(); // we use the lambda expression to find all positive numbers and take the Minumum number
        Console.WriteLine($" The smallest positive number is {smallestpositive}");

        // Sorting the list

        var sorting = list.OrderBy(n => n).ToList(); // We sort the list from lower number to the bigest number

        Console.WriteLine($"The sorted list is :");
        foreach (int numbers in sorting)
        {
            Console.WriteLine(numbers);
        }

    }
}