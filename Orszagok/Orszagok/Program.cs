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
            public string Orszagnev { get; private set; }
            public int Terulet { get; private set; }
            public int Nepesseg { get; private set; }
            public string Fovaros { get; private set; }
            public int FovarosNepesseg { get; private set; }

            public Orszag(string sor)
            {
                string[] orszagok = sor.Split(';');
                Orszagnev = orszagok[0];
                Terulet = int.Parse(orszagok[1]);
                if (orszagok[2].Contains("g"))
                {
                    string szorzas = orszagok[2];
                    Nepesseg = int.Parse(szorzas.Substring(0, szorzas.Length - 1)) * 10000;
                }
                else
                {
                    Nepesseg = int.Parse(orszagok[2]);
                }
                Fovaros = orszagok[3];
                FovarosNepesseg = int.Parse(orszagok[4]) * 1000;
            }
            public int Nepsuruseg()
            {
                int nsuruseg;
                nsuruseg = Nepesseg / Terulet;

                return nsuruseg;
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
            Console.WriteLine("3.Feladat:");
            Console.WriteLine("Beolvasott országok száma: {0}",dlista.Count);

            Console.WriteLine("4.Feladat:");
            foreach (Orszag o in dlista)
            {
                if (o.Orszagnev == "Kína")
                {
                    Console.WriteLine("Kína népsűrűsége: {0} fő/km^2", o.Nepsuruseg());
                }            
            }

            Console.WriteLine("5.Feladat");
            int indian = 0;
            int kinan = 0;
            foreach (Orszag o in dlista)
            {
                if (o.Orszagnev == "Kína")
                {
                    kinan = o.Nepesseg;
                }
                if (o.Orszagnev == "India")
                {
                    indian = o.Nepesseg;
                }
            }
            Console.WriteLine("Kínában a lakosság {0} fővel volt több.",kinan-indian);

            Console.WriteLine("6.Feladat:");
            int harmadiklegnepesebb = 0;
            for (int i = 0; i < dlista.Count; i++)
            {
                if (dlista[i].Orszagnev != "Kína" && dlista[i].Orszagnev != "India" && dlista[i].Nepesseg > dlista[harmadiklegnepesebb].Nepesseg)
                {
                    harmadiklegnepesebb = i;
                }
            }
            Console.WriteLine($"A harmadik legnépesebb ország: {dlista[harmadiklegnepesebb].Orszagnev}, a lakosság {dlista[harmadiklegnepesebb].Nepesseg} fő.");
            Console.ReadLine();
        }
    }
}
