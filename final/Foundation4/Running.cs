using System;
public class Running : Activity 
{
    
    //protected int _distance; 
    public Running(int minutes, string date, int distance) : base(minutes, date)
    {
        _minutes = minutes;
        _date = date;
        _distance = distance;
    }
    public override int GetSpeed()
    {
        //_speed = _distance / _minutes * 60;
        return (int)(_distance / _minutes * 60);
    }
    protected override string GetActivity()
    {
        return "Running";
    }
}