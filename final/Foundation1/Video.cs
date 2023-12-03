using System;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _numberOfComments = 0;
    public Comment _comment;
    public List<Comment> comments = new List<Comment>();
    // public List <Video> videos = new List<Video>();
    public void DisplayVideo()
    {
        Console.WriteLine($"The title of the video is {_title} by {_author} and is {_length} seconds long.");
        foreach (Comment comment in comments)
        {
            _numberOfComments = 0;
            comment.DisplayComments();
            _numberOfComments ++;
        }
        Console.WriteLine($"There are {_numberOfComments} comments on this video");
    }
}

