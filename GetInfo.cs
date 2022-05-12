using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    internal class GetInfo : Command// CommandOne 
    {
        public GetInfo(string videoUrl) : base(videoUrl)
        {
        }

        public override async Task Run()
        {
            await vm.PrintInfoAsync();
        }


    }
}
