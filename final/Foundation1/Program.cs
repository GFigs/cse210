using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Foo Fighters - The Pretender", "Foo Fighters", 270);
        Comment comment1 = new Comment("leokimvideo", "RIP Taylor Hawkings");
        Comment comment2 = new Comment("Iron Chonk", "Absolute Masterpiece");
        Comment comment3 = new Comment("baby nyxe", "I used to listen to this song shen I was very young");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);


        Video video2 = new Video("AudioSlave - Like a Stone", "AudioSlave", 301);
        Comment comment4 = new Comment("RayRay", "I will never forget he sang this live at a concert");
        Comment comment5 = new Comment("Karla K", "Always gives me goosebumps");
        Comment comment6 = new Comment("Pepsi Fire", "i Played this on repeat last week");
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        Video video3 = new Video("Radiohead - Creep", "Radiohead", 236);
        Comment comment7 = new Comment("FamouslyUnheardOf", "This always hits me right in the feels");
        Comment comment8 = new Comment("Rosha Harned", "One of the last decent conversations I had was about this song");
        Comment comment9 = new Comment("Slav Abtomat", "That this song is more than 30 years old blows my mind");
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);


        List<Video> videosList = new List<Video>();
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            Console.WriteLine($"{video.GetTitle()} uploaded by {video.GetAuthor} is {video.GetLength()} seconds long and it has {video.GetNumComments()} comments.");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  {comment.GetUser()}: {comment.GetText()}");
            }
            Console.WriteLine("");
        }
    }
}