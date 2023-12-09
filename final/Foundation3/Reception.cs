using System;
public class Reception : Event
{
    protected string _rsvpEmail;
    public Reception(string title, string description, string date, string time, string address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    protected override string GetType()
    {
        return "Reception";
    }
    protected override string GetAddress()
    {
        return _address;
    }
    public string GetRsvp()
    {
        return _rsvpEmail;
    }
        public string GetLongDetails()
    {
        return $"The type is {GetType()}. Title of event {_title} is {_description}. It happens on {_date} {_time}. At {GetAddress()} It has {GetRsvp()} reserved.";
    }

}