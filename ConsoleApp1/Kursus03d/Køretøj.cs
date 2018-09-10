using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    public class Køretøj
    {
        public int AntalHjul { get; set; }
        public string TypeHjul { get; set; }

        public virtual void Oplysninger()
        {
            Console.WriteLine($"Antal Hjul: {this.AntalHjul}, og type hjul: {this.TypeHjul}");
            Console.ReadLine();
        }

    }
}
