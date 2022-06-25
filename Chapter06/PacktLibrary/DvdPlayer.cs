using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("The DVD is paused");
        }

        public void Play()
        {
            WriteLine("The DVD is playing");
        }

        public void Stop() { WriteLine("Default implementation of stop"); }
    }
}
