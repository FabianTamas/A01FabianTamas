using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01FabianTamas
{
    class Program
    {
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A maximum: {0}", Maximumertek());

            Console.ReadKey();
        }

        private static void Maximumertek()
        {
            int max = 0;
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i]>max)
                {
                    max = adat[i];
                }
            }
        }

        private static void Beolvasas()
        {
            StreamReader adatok = new StreamReader("adatok.dat");
            while (!adatok.EndOfStream)
            {
                string[] atmeneti = adatok.ReadLine().Split(' ');
                int[] adat = new int[1000];
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(atmeneti[i]);
                    Console.Write("{0}", adat[i]);
                }
            }
            adatok.Close();

        }
    }
}
