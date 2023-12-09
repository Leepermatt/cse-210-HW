using System;
public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;
    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    protected override string GetType()
    {
        return "Lecture";
    }
    public string GetLongDetails()
    {
        return $"The type is {GetType()}. Title of event {_title} and is a {_description}. It happens on {_date} {_time} at {GetAddress()}. It has {GetSpeaker()} speaking. A capacity of {GetCapacity()} people.";
    }
}