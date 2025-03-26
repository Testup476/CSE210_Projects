using System;
using System.Collections.Generic;
using YouTubeVideos;


class Program
{

  static void Main(string[] args)
  {
    Video _video1 = new Video("Learn C# with Marc", "Bob", 100);
    _video1.add_comment("Alice", "Good Job Bob");
    _video1.add_comment("John", "This is the Powerful video never seen before");
    _video1.add_comment("Petter", "Thank your for sharing");

    Video _video2 = new Video("Learn Python in 1 hours", "Jule", 5000);
    _video2.add_comment("Alice", "Good Job Jule, It is helpful");
    _video2.add_comment("Marc", "Thank your for sharing");
    _video2.add_comment("Petter", "Thank your for sharing");

    Video _video3 = new Video("Learn JavaScript in 24 minutes ", "Kanda", 1000);
    _video3.add_comment("Alice", "Good Job Kanda");
    _video3.add_comment("Petter", "Thank your for sharing");
    _video3.add_comment("Gisele", "Thank your");


    List<Video> videos = new List<Video>();
    videos.Add(_video1);
    videos.Add(_video2);
    videos.Add(_video3);
    foreach (var video in videos)
    {
      Console.WriteLine("------------------");
      Console.WriteLine($" Title : {video._Title}");
      Console.WriteLine($" Author : {video._author}");
      Console.WriteLine($" Video size : {video._Videosize}");
      Console.WriteLine($"{video.Get_number()}");
      Console.WriteLine($"{video.Get_comments()}");
    }
  }
}