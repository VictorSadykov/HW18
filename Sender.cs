using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    internal class Sender
    {
        Download downloadOperation;
        GetInfo getInfoOperation;

        public void SetCommands(string videoUrl, string filePath)
        {
            downloadOperation = new Download(videoUrl, filePath);
            getInfoOperation = new GetInfo(videoUrl);
        }

        public async Task Run()
        {
            await getInfoOperation.Run();
            await downloadOperation.Run();
        }
    }
}
