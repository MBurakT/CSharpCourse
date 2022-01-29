using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 95;

            if (number < 100)
            {
                if(number > 90)
                {
                    Console.WriteLine(number);
                }
            }           

            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }
}
