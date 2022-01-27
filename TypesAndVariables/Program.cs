using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            var number1 = 10;
            Console.WriteLine("Number is {0} {1}", number1, Days.Monday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Fridey,Saturday,Sunday
    }
}
