using System;
public class EternalGoal : Goals
{
    public  EternalGoal() : base()
    {
    }
    public EternalGoal(StreamReader read) : base(read)
    {
    }
    public override void Complete()
    {
        _totalPointsEarned += _pointsCompletion;
    }
    protected override string GetGoalComplete()
    {
        return "Each time this activity is repeated";
    }
    protected override string GetGoalName()
    {
        return "Eternal Goal";
    }
}
