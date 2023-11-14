using System;
public class Breathing : Mindfulness
{
    public Breathing(int time) : base(time)
    {
        _activity = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    }
    public void RunBreathingActivity()
    {
        WelcomeMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            // PUT "Breath in..."
            Console.WriteLine("Breath in ...");
            CountDown(5);
            // PUT Breath out...
            Console.WriteLine("Breath out...");
            CountDown(5);
        }
        EndMessage();
    }
}
