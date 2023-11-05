using System;

public class Assignment
{
    private string _studentName="";
    private string _topic="";
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudent(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $" Student Name {_studentName} and topic {_topic}";
    }

}

