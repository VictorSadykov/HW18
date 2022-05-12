using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    internal class Download : Command //CommandTwo
    {
        
        public Download(string videoUrl, string filePath) : base(videoUrl, filePath)
        {
            
        }

        public override async Task Run()
        {
            await vm.Download();
        }
    }
}
