using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orszagok
{
    internal class Program
    {
        class Orszag
        {
            public string nev;
            public int terulet;
            public string nepesseg;
            public string fovaros;
            public int fovnepesseg;

            public Orszag(string sor)
            {
                string[] orszagok = sor.Split(';');
                this.nev = orszagok[0];
                this.terulet = int.Parse(orszagok[1]);
                this.nepesseg = orszagok[2];
                this.fovaros = orszagok[3];
                this.fovnepesseg = int.Parse(orszagok[4]);
            }
        }
        static void Main(string[] args)
        {
            List<Orszag> dlista = new List<Orszag>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                dlista.Add(new Orszag(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("4.Feladat:");
            Console.WriteLine("Beolvasott országok száma: {0}",dlista.Count);
            Console.ReadLine();
        }
    }
}
