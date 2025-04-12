class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public override bool IsComplete => _currentCount >= _targetCount;

    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int currentCount = 0)
    {
        Name = name;
        Description = description;
        Points = points;
        _bonus = bonus;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            _currentCount++;
            Console.WriteLine($"You earned {Points} points!");
            if (IsComplete)
            {
                Console.WriteLine($"Bonus! You earned an extra {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("Goal already fully completed.");
        }
    }

    public override string GetStatus() =>
        $"[{(IsComplete ? "X" : " ")}] {Name} (Completed {_currentCount}/{_targetCount})";

    public override string Serialize() =>
        $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_currentCount}";
}