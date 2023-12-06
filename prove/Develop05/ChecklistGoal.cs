using System;
public class ChecklistGoal : Goals
{
    private int _timesCompleted = 0;
    private int _toDo = 0;
    private int _bonusPoints = 0;
    public ChecklistGoal() : base()
    {
        Console.WriteLine("How many times to complete goal?");
        _toDo = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for completioning?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public ChecklistGoal(StreamReader read) : base(read)
    {
        _timesCompleted = int.Parse(Console.ReadLine());
        _toDo = int.Parse(Console.ReadLine());
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override void Complete()
    {
        if (!_completed)
        {
            _timesCompleted++;
            _totalPointsEarned += _pointsCompletion;
            if (_timesCompleted == _toDo)
            {
                _totalPointsEarned += _bonusPoints;
                _completed = true;
            }
        }
    }
    public override string GetCompletedDisplay()
    {
        return $"{base.GetCompletedDisplay()} {GetProgressStatus()} ";
    }
    private string GetProgressStatus()
    {
        return $"Completed {_timesCompleted}/ {_toDo} times";
    }
    protected override string GetGoalName()
    {
        return "checklist goal";
    }
    protected override string GetGoalComplete()
    {
        return "each time you complete this goal";
    }
    public override void WritetoStreamWriter(StreamWriter w)
    {
        base.WritetoStreamWriter(w);
        w.WriteLine(_timesCompleted);
        w.WriteLine(_toDo);
        w.WriteLine(_bonusPoints);
    }
}