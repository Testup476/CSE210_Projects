using System;

namespace Homework{
    public class Assignment
{
      protected string _studentName { get; set; }
      private string _topic { get; set; }

      public Assignment(string studentname, string topic)
      {
          _studentName = studentname;
          _topic = topic;
      }

      public string GetSummary()
      {
          return $"{_studentName} - {_topic}";
      }
}
}

