using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Black Soup", "Chef Yetunde", 300);
        video1.AddComment(new Comment("Ademola", "Looks delicious!"));
        video1.AddComment(new Comment("Bello", "Can't wait to try this."));
        video1.AddComment(new Comment("Abayomi", "Great tutorial!"));
        videos.Add(video1);

        Video video2 = new Video("DIY Tips: Making Your Own Backpack", "TrailBlazer", 450);
        video2.AddComment(new Comment("Mensah", "Super helpful!"));
        video2.AddComment(new Comment("Imafidon", "I really learned a lot."));
        video2.AddComment(new Comment("Frederica", "Time to hit the trails!"));
        videos.Add(video2);

        Video video3 = new Video("HTML In One Hour", "Tomi Tomishey", 600);
        video3.AddComment(new Comment("Irina", "Very very very helpful."));
        video3.AddComment(new Comment("Henrina", "Love the presentation."));
        video3.AddComment(new Comment("Ivory", "This has inspired me greatly."));
        videos.Add(video3);
foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}