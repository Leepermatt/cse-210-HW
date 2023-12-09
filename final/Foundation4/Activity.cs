using System;
public abstract class Activity
{
    protected string _date;
    protected string _activityName;
    protected int _minutes;
    protected int _speed;
    protected int _distance;
    protected int _pace;
    public Activity (int minutes, string date)
    {
        _minutes = minutes;
        _date = date;
    }
    protected virtual string GetDate()
    {
        return _date;
    }
    protected virtual int GetMinutes()
    {
        return _minutes;
    }
    public virtual int GetDistance()
    {

        return _distance;
    }
    protected virtual int GetPace()
    {
        //_pace = (int)(60 / GetSpeed());
        return _pace;
    }
    protected virtual string GetActivity()
    {
        return _activityName;
    }
    public abstract int GetSpeed();
    //{
        //int  _speed = _distance / _minutes * 60;
        
        //return _speed;
    //}
    public virtual string GetSummary()
    {
        return ($"{GetDate()} {GetActivity()} ({GetMinutes()} minutes)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace GetPace() min per mile");
        // return ($"{GetDate()} {GetActivity()} ({GetMinutes()}minutes)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile");
    }
}
