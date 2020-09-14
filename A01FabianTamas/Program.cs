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
            Console.WriteLine("A maximum: {0}", Maximumertek(max));
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", Egyediek(i));

            Console.ReadKey();
        }

        private static int Egyediek(int i)
        {
            while (i<adat.Length && i%5==0 && i%7==0)
            {
                i++;
            }
            if (i<adat.Length)
            {
                return i;
            }

            StreamWriter sw = new StreamWriter("egyediek.txt", true);
            string egyedi = i.ToString();
            sw.WriteLine(egyedi);
            sw.Close();
        }

        private static void Maximumertek(int max)
        {
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i]>max)
                {
                    max = adat[i];                 
                }
            }
            return max;
        }

        public static void Beolvasas()
        {
            StreamReader adatok = new StreamReader("adatok.dat");
            while (!adatok.EndOfStream)
            {
                string[] atmeneti = adatok.ReadLine().Split(' ');
                int[] adat = new int[1000];
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(atmeneti[i])*2;                                  
                }
                for (int i = 0; i < adat.Length; i++)
                {
                    Console.Write("{0}", adat[i]);
                }
            }
            adatok.Close();

        }
    }
}
