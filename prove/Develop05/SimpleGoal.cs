using System;
public class SimpleGoal : Goals
{
    public SimpleGoal() : base()
    {

    }
    public SimpleGoal(StreamReader read) : base(read) 
    { 

    }
    public override void Complete()
    {
        if (!_completed)
        {
            _completed = true;
            _totalPointsEarned += _pointsCompletion;
        }
    }
    protected override string GetGoalComplete()
    {
        return "Done";
    }
    protected override string GetGoalName()
    {
        return "one-time goal";
    }
}