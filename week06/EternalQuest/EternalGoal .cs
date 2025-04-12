class EternalGoal : Goal
{
    public override bool IsComplete => false;

    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points!");
    }

    public override string GetStatus() => $"[∞] {Name}";

    public override string Serialize() => $"EternalGoal|{Name}|{Description}|{Points}";
}
