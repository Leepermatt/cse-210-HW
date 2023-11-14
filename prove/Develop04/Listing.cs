using System;
public class Listing : Mindfulness
{
    public Listing(int time) : base(time)
    {
        _activity = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }
    private List<string> listingList = new()
    {
        "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
    };
    private List<string> log = new();
    public void ListingList()
    {
        Random rnd = new Random();
        string d = listingList[rnd.Next(listingList.Count)];
        Console.WriteLine(d);
    }
    public void RunListingActivity()
    {
        WelcomeMessage();
        Console.WriteLine("List as many responses as you can to the following Prompt:");
        ListingList();
        Spinner(10);
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
        }
        EndMessage();
    }
    public string GetListingActivity()
    {
         return _activity;
    }
    public void SetListingActivity(string activity)
    {
        _activity = activity;
    }
}