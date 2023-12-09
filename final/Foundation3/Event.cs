using System;
public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;
    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    protected virtual string GetType()
    {
        return _type;
    }
    protected virtual string GetAddress()
    {
        return _address;
    }
    public string GetStandardDetails()
    {
        return $"Title of event {_title} and is a {_description}. It happens on {_date} {_time} at {GetAddress()}";
    }
    public string GetShortDetails()
    {
        return $"{GetType()} {_title} is on {_date}.";
    }
}