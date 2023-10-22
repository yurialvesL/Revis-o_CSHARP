using System;
using System.Diagnostics.Contracts;
using Enum_Ex2.Entitites;
public class Program
{
   public static void Main()
    {
        Comment comment = new Comment("Have a nice trip");

        Comment comment2 = new Comment("Wow that's awesom!");

        Post post = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

        post.AddComment(comment);
        post.AddComment(comment2);

        Comment comment3 = new Comment("Good Night");
        Comment comment4 = new Comment("May the Force be with you");
        Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys","See you tomorrow",5);
        post2.AddComment(comment3);
        post2.AddComment(comment4);

        Console.WriteLine(post.ToString());
        Console.WriteLine(post2);
    }
}