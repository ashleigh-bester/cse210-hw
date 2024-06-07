using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

        public double DisplayNoOfComments()
    {
        double noComments = _comments.Count();
        return noComments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} | {_author} ({_length}s)");
        Console.WriteLine($"Comments: {DisplayNoOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}