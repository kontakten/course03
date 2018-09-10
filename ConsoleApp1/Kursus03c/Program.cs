using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03c
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();

            pList.Add(new Person {
                Id = 1,
                Navn = "Mikkel"
            });
            pList.Add(new Person
            {
                Id = 2,
                Navn = "Nicki"
            }); pList.Add(new Person
            {
                Id = 3,
                Navn = "Gitte"
            });
            pList.Add(new Person
            {
                Id = 4,
                Navn = "Henrik"
            });

            foreach (var item in pList)
            {
                Console.WriteLine($"Id: {item.Id}, Navn: {item.Navn}");
            }

            Dictionary<int, Person> nyPList = new Dictionary<int, Person>();

            nyPList.Add(1, new Person { Id = 1, Navn = "Nicki" });

            nyPList.Add(2, new Person { Id = 2, Navn = "Mikkel" });

            nyPList.Add(3, new Person { Id = 3, Navn = "Gitte" });

            nyPList.Add(4, new Person { Id = 4, Navn = "Henrik" });

            var specifikPerson = nyPList[2];

            Console.WriteLine($"Specifik Person: {specifikPerson.Id}, {specifikPerson.Navn}");

            Console.ReadLine();


            Bunke b = new Bunke();
            b.TilføjKort(new Kort { Kulør = "Ruder", Værdi = 3 });
            b.TilføjKort(new Kort { Kulør = "Hjerter", Værdi = 5 });
            b.TilføjKort(new Kort { Kulør = "Spar", Værdi = 8 });
            b.TilføjKort(new Kort { Kulør = "Spar", Værdi = 1 });
            b.TilføjKort(new Kort { Kulør = "Klør", Værdi = 6 });

            var k = b.FjernKort();

            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            Console.ReadLine();

        }

    }
    class Person
    {
        public int Id { get; set; }

        public string Navn { get; set; }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
    class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }

        public Kort FjernKort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
        }
    }
}
