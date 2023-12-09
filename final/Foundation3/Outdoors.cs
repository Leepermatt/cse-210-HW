using System;
public class Outdoors : Event
{
    protected string _weather;
    
    public Outdoors(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
        protected override string GetType()
    {
        return "Outdoors";
    }
    public string GetWeather()
    {
        return _weather;
    }
        public string GetLongDetails()
    {
        return $"The type is {GetType()}. Title of event {_title} and is a {_description}. It happens on {_date} {_time} at {GetAddress()}. It has {GetWeather()} forcasted.";
    }
}