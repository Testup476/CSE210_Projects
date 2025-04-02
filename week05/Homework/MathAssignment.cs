namespace Homework;

public class MathAssignment : Assignment
{
    private string _textbook{get;set;}
    private string _problem{get;set;}
    public MathAssignment(string studentname, string topic, string textbook, string problem) 
    : base(studentname,topic)
    {
        _textbook=textbook;
        _problem=problem;
    }    

    public string GetHomeWorkList()
    {
        return $"{base.GetSummary()} in {_textbook} - {_problem}";
    }
    
}