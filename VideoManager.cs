using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HW18
{
    internal class VideoManager // Reciever
    {
        private YoutubeClient _youtubeClient = new YoutubeClient();
        protected string _videoUrl;
        protected string _filePath;
        public VideoManager(string videoUrld, string filePath)
        {
            _videoUrl = videoUrld;
            _filePath = filePath;
        }
        public async Task PrintInfoAsync()
        {
            var video = await _youtubeClient.Videos.GetAsync(_videoUrl);
            Console.WriteLine($"Название: {video.Title}\nОписание: {video.Description}$");
        }

        public async Task Download()
        {
           await _youtubeClient.Videos.DownloadAsync(_videoUrl, _filePath);
        }
    }
}
