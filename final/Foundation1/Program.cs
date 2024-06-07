using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Going on Safari";
        video1._author = "Cheryl Fourie";
        video1._length = 30;

        Comment comment1 = new Comment();
        comment1._name = "Susan";
        comment1._text = "So exciting!";
        video1._comments.Add(comment1);
        
        Comment comment2 = new Comment();
        comment2._name = "Steve";
        comment2._text = "Wow! That was a lot of lions!";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "Patricia";
        comment3._text = "Where was this recorded?";
        video1._comments.Add(comment3);
        

        Video video2 = new Video();
        video2._title = "How to Bake a Carrot Cake";
        video2._author = "Riley Bester";
        video2._length = 60;

        Comment comment4 = new Comment();
        comment4._name = "Steve";
        comment4._text = "Yum!";
        video2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._name = "May";
        comment5._text = "This recipe worked really well :)";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._name = "Gabriel";
        comment6._text = "My fav chef ever!";
        video2._comments.Add(comment6);  

        Video video3 = new Video();
        video3._title = "Got the Fright of My Life!";
        video3._author = "Venessa Groenewald";
        video3._length = 90;

        Comment comment7 = new Comment();
        comment7._name = "Harry";
        comment7._text = "Was not expecting that.";
        video3._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._name = "Banele";
        comment8._text = "I would've run far away!";
        video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._name = "Adriaan";
        comment9._text = "That wasn't scary at all.";
        video3._comments.Add(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}