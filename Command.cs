using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    internal abstract class Command
    {
        protected VideoManager vm;

        public Command(string videoUrl, string filePath = null)
        {
            vm = new VideoManager(videoUrl, filePath);
        }

        public abstract Task Run();


    }
}
