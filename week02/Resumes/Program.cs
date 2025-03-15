using System;
using Resumers;

class Program
{
    static void Main(string[] args)
    {
        Job Firstjob = new Job()
        {
            _Company = "Microsoft",
            _JobTitle = "Software Engineer",
            _startYear = 2017,
            _endYear = 2024
        };

        Job secondJob = new Job()
        {
            _Company = "TestUp",
            _JobTitle = "TakeAway",
            _startYear = 2015,
            _endYear = 2026
        };

        var _resume = new Resume();
        _resume._name = "Kanda";
        _resume._Jobs.Add(Firstjob);
        _resume._Jobs.Add(secondJob);
        _resume.Display();


    }
}