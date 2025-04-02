namespace Homework;

public class WritingAssignment :Assignment
{
    private string _title { get; set; }

    public WritingAssignment(string studentname, string topic, string title) : base(studentname,topic)
    {
        _title=title;
    }
    public string GetWritingInfo()
    {
        return $"{_title}  by {base._studentName}";
    }
}