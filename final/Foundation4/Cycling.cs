using System;
public class Cycling : Activity
{
    public Cycling(int minutes, string date, int speed) : base(minutes, date)
    {
        _minutes = minutes;
        _date = date;
        _speed = speed;
    }
    public override int GetSpeed()
    {
        return _speed;
    }
    public override int GetDistance()
    {
        _distance = (int)(GetSpeed()*_minutes/ 60);
        return _distance;
    }

    protected override string GetActivity()
    {
        return "Cycling";
    }
}