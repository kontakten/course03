using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Terning
    {

        private int værdi;

        private static System.Random ryst = new Random();

        public int Værdi
        {
            get {
                Console.WriteLine("Der aflæses værdi");
                return værdi;
            }
            set {
                Console.WriteLine("Der sættes en værdi");
                if (value < 1 || value > 6)
                    værdi = 1;
                værdi = value;
            }
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
            this.Ryst();
        }
        public Terning()
        {
            this.Ryst();
        }
        public void Ryst()
        {
            Værdi = ryst.Next(1, 6);
        }

        public void Skriv()
        {
            Console.WriteLine($"Værdi på terning er: [{this.Værdi}]");
            Console.ReadLine();
        }
    }
}
