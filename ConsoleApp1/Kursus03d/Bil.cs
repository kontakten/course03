using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    class Bil : Køretøj
    {
        public bool AutomatiskGear { get; set; }

        public override void Oplysninger()
        {
            base.Oplysninger();
            if(AutomatiskGear)
                Console.WriteLine("Bil har automatisk gear");
        }

    }
}
