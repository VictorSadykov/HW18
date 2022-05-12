using YoutubeExplode;

namespace HW18
{
    class Program
    {
        public static async Task Main()
        {
            Sender sender = new Sender();
            sender.SetCommands("https://www.youtube.com/watch?v=668nUCeBHyY", "video.mp4");
            await sender.Run();


        }
    }
}