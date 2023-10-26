using System;
public class WritingAssignment : Assignment
{
    private  string _title;

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $" Student name is {GetStudentName()} the topic is {GetTopic()} and the title is {_title} by {GetStudentName()}";
    }
}