using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.Navn = "Mikkel";

            p.Pris = 1000;

            var prisInklMoms = p.PrisMedMoms();

            Console.WriteLine($"Navn: {p.Navn} - Har en pris med moms: {prisInklMoms}");

            Person p2 = new Person("Nicki", 33, 5000);

            prisInklMoms = p2.PrisMedMoms();

            Console.WriteLine($"Navn: {p2.Navn} - Har en pris med moms: {prisInklMoms}");

            Console.ReadLine();

            Person p3 = new Person();
            p3.Fornavn = "Henrik";
            p3.Efternavn = "Stensgaard";

            Console.WriteLine($"Fuldt navn {p3.FuldtNavn}");

            Console.WriteLine($"Fuldt navn {p3.MFuldtNavn()}");

            Trekant tre = new Trekant(10, 20);

            Console.WriteLine($"{tre.Areal}");

            Console.ReadLine();

            Terning ter = new Terning();

            ter.Værdi = 4;

            ter.Skriv();

            ter.Ryst();

            ter.Skriv();

            Terning ter2 = new Terning(2);

            ter2.Skriv();

            ter2.Ryst();

            ter2.Skriv();

        }
    }
}
