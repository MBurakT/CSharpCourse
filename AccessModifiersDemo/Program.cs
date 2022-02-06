using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Başka bir projeden bir classı kullanmak için önce referans olarak eklememiz ve kullanacağımız yere using yaparak eklememiz gerekir
            //Ayrıca başka bir projeden kullanmak istediğimiz classlar public olarak tanımlanmalıdır
            Course course = new Course();

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }
}
