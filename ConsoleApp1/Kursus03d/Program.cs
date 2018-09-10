using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    class Program
    {
        static void Main(string[] args)
        {
            Køretøj kt = new Køretøj { AntalHjul = 2, TypeHjul = "Sommerdæk" };

            Bil b = new Bil { AntalHjul = 4, TypeHjul = "Vinterdæk", AutomatiskGear = true };

            Motorcykel mc = new Motorcykel { AntalHjul = 3, Sidevogn = true, TypeHjul = "Sommerdæk" };

            kt.Oplysninger();

            b.Oplysninger();

            mc.Oplysninger();

            UdvidRandom r = new UdvidRandom();

            Console.WriteLine(r.NextBool());

            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Faktura nyFaktura = new Faktura { Nr = 1337, Kunde = "Mikkel", Dato = DateTime.Now };

            Console.WriteLine(nyFaktura.ToString());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
