using System;
public class Comment 
{
    public string _name;
    public string _comment;
    public void DisplayComments()
    {
        Console.WriteLine ($"{_name} made the following comment.. {_comment}..");      
    }
}
