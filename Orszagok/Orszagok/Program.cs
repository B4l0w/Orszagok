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
            public int nepesseg;
            public string fovaros;
            public int fovnepesseg;

            public Orszag(string sor)
            {
                string[] orszagok = sor.Split(';');
                this.nev = orszagok[0];
                this.terulet = int.Parse(orszagok[1]);
                this.nepesseg = int.Parse(orszagok[2]);
                this.fovaros = orszagok[3];
                this.fovnepesseg = int.Parse(orszagok[4]);
            }
        }
        static void Main(string[] args)
        {
            List<Orszag> orszaglista = new List<Orszag>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            
            while (!sr.EndOfStream)
            {
                orszaglista.Add(new Orszag(sr.ReadLine()));
            }
        }
    }
}
