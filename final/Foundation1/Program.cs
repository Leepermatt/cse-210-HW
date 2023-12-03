using System;
class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        Comment c1 = new Comment();
        c1._name = "Bob Smith";
        c1._comment = "Loved this one";

        Comment c2 = new Comment();
        c2._name = "Joe Mack";
        c2._comment = "Best one ever";

        Comment c3 = new Comment();
        c3._name = "July Orange";
        c3._comment = "Hated this one";

        Comment c4 = new Comment();
        c4._name = "Betty Lou";
        c4._comment = "My Favorite";

        Video v1 = new Video();
        v1._author = "Joseph Smith";
        v1._title = "Book of Mormon";
        v1._length = 1589;

        Video v2 = new Video();
        v2._author = "Brigham Young";
        v2._title = "Arriving in Salt Lake";
        v2._length = 1879;

        Video v3 = new Video();
        v3._author = "Russell Nelson";
        v3._title = "Modern Times";
        v3._length = 2023;

        v1.comments.Add(c1);
        v1.comments.Add(c2);
        v1.comments.Add(c4);
        v2.comments.Add(c4);
        v2.comments.Add(c3);
        v3.comments.Add(c1);
        v3.comments.Add(c3);
        v3.comments.Add(c2);
        v1.DisplayVideo();
        v2.DisplayVideo();
        v3.DisplayVideo();
    }
}