using System;

class Program
{
  static void Main(string[] args)
  {
    videos videos = new videos();
    videos.tittle = "He Lied Again";
    videos.author = "Hayden";
    videos.length = 30;
    Console.WriteLine(videos.GetVideoDetails());
    comment comment = new comment();
    comment.name = "James";
    comment.name1 = "Mirriam";
    comment.name2 = "John";
    Console.WriteLine(comment.GetCommentors());

  }
}