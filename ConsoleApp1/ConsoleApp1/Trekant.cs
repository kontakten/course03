using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trekant
    {
        private int grundlinje;
        private int hoejde;

        public int Hoejde
        {
            get { return hoejde; }
        }

        public int Grundlinje
        {
            get { return grundlinje; }
        }

        public Trekant(int grundlinje, int hoejde)
        {
            this.grundlinje = grundlinje;
            this.hoejde = hoejde;
        }

        public double Areal
        {
            get {
                return this.Grundlinje * this.Hoejde * 0.5;
            }
        }
    }
}
