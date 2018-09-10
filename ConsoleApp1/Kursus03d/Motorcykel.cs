using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    class Motorcykel : Køretøj
    {
        public bool Sidevogn { get; set; }
        public override void Oplysninger()
        {
            base.Oplysninger();
            if (Sidevogn)
                Console.WriteLine("Motorcykel har sidevogn");
        }
    }
}
