using System;
public class Listing : Mindfulness
{
    private string _activity = "Listing Activity";
    private string _welcomePrompt =" on the good things in your life by having you list as many things as you can in a certain area.";
    public void ListingList()
    {
        List<string> listingList = new List<string>();
        listingList.Add("Who are people that you appreciate?");
        listingList.Add("What are personal strengths of yours?");
        listingList.Add("Who are people that you have helped this week?");
        listingList.Add("When have you felt the Holy Ghost this month?");
        listingList.Add("Who are some of your personal heroes?");
        Random rnd = new Random();
        string d = listingList[rnd.Next(listingList.Count)];
        Console.WriteLine("List as many responses as you can to the following Prompt:");
        Console.WriteLine($"----{d}----");
    }
    public void InputList()
    {

    }
    public string GetListingActivity()
    {
         return _activity;
    }
    public string GetListingWelcome()
    {
        return _welcomePrompt;
    }
}