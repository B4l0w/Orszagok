using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orszagok
{
    internal class Program
    {
        class Orszagok
        {
            public string nev;
            public int terulet;
            public int nepesseg;
            public string fovaros;
            public int fovnepesseg;

            public Orszagok(string sor)
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
        }
    }
}
