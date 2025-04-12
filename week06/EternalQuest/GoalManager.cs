class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Enter the number of the goal you completed: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            var goal = _goals[index - 1];
            int beforeScore = _score;
            goal.RecordEvent();

            if (goal is SimpleGoal s && !s.IsComplete)
                _score += s.Points;
            else if (goal is EternalGoal e)
                _score += e.Points;
            else if (goal is ChecklistGoal c)
            {
                int earned = c.IsComplete && _score == beforeScore ? c.Points + 0 : c.Points;
                if (c.IsComplete && beforeScore == _score)
                    earned += 500; // assuming bonus
                _score += earned;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"\nYour current score: {_score} points\n");
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.Serialize());
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            _goals.Add(Goal.Deserialize(lines[i]));
        }

        Console.WriteLine("Goals loaded.");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        string option = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (option)
        {
            case "1":
                AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                AddGoal(new ChecklistGoal(name, desc, points, bonus, target));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}