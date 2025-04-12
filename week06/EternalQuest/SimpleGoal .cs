class SimpleGoal : Goal
{
    private bool _completed;

    public override bool IsComplete => _completed;

    public SimpleGoal(string name, string description, int points, bool completed = false)
    {
        Name = name;
        Description = description;
        Points = points;
        _completed = completed;
    }

    public override void RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            Console.WriteLine($"You earned {Points} points!");
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override string GetStatus() => $"[{(IsComplete ? "X" : " ")}] {Name}";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{_completed}";
}