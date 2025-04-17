using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now.AddDays(-2), 30, 5.0),
            new Cycling(DateTime.Now.AddDays(-1), 45, 20.0),
            new Swimming(DateTime.Now, 25, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}