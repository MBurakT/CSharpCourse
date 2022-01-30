using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach readonly durumdadır

            string[,] regions = new string[5, 3]
            {
                { "İstanbul", "Bilecik", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Aydın" }
            };
            int i = regions.GetUpperBound(1);

            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            foreach (var region in regions)
            {
                if (i == 0)
                {
                    Console.WriteLine(region);
                    i = regions.GetUpperBound(1);
                }
                else
                {
                    Console.Write(region + " (\\ô.ô/) ");
                    i--;
                }
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();

        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i / 2 * 2 == i)
                {
                    Console.Write(i + " (\\ô.ô/) ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void WhileLoop()
        {
            int i = 0;
            while (i < 100)
            {
                if (i / 2 * 2 == i)
                {
                    Console.Write(i + " (\\ô.ô/) ");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine(i);
        }

        private static void DoWhileLoop()
        {
            int i = 0;
            do
            {
                if (i / 2 * 2 == i)
                {
                    Console.Write(i + " (\\ô.ô/) ");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 100);
            Console.WriteLine(i);
        }
    }
}
