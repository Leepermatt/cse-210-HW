using System;
public class Swimming : Activity
{
    protected int _laps;
    public Swimming(int minutes, string date, int laps) : base(minutes, date)
    {
        _minutes = minutes;
        _date = date;
        _laps = laps;
    }
    protected override string GetActivity()
    {
        return "Swimming";
    }
    public override int GetDistance()
    {
        _distance = (int)(_laps * 50 / 1000 * 0.62);
        return _distance;
    }
    public override int GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }
}