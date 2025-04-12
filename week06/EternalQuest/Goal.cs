using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }
    public abstract bool IsComplete { get; }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
    public static Goal Deserialize(string line)
    {
        var parts = line.Split('|');
        string type = parts[0];

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])),
            "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
            _ => throw new Exception("Unknown goal type")
        };
    }
}
