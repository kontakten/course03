using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string fornavn;
        private string efternavn;

        private string navn;
        private int alder;
        private double pris;

        public string Navn
        {
            get {
                Console.WriteLine("Der aflæses Navn !");
                return navn;
            }
            set {
                Console.WriteLine("Navn bliver sat !");
                navn = value;
            }
        }

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        public double Pris
        {
            get {
                Console.WriteLine("Der aflæses pris !");
                return pris;
            }
            set {
                Console.WriteLine("Pris bliver sat !");
                pris = value;
            }
        }

        public string FuldtNavn
        {
            get { return Fornavn + " " + Efternavn; }
        }


        public string Fornavn { get; set; }

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length <= 2)
                    efternavn = "";
                efternavn = value;
            }
        }

        public Person()
        {

        }

        public Person(string navn, int alder, double pris)
        {
            this.navn = navn;
            this.alder = alder;
            this.pris = pris;
        }

        public string MFuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public double PrisMedMoms()
        {
            return pris * 1.25;
        }
    }
}
