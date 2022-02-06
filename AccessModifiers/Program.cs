using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    //private sadece tanımlandığı scope içinde kullabilirken protected inheritance edildiği sınıflarda da kullanılabilir
    //private değişkenler için default erişim bildirgeçidir
    class Customer
    {
        private int id;
        protected int id2;
    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
        }
    }
    //internal bağlı bulunduğu projede referans ihtiyacı olmadan kullanılabilir, default class erişim bildirgeçidir
    //bir class private veya protected olarak tanımlanamaz, ya internal ya da public olarak tanımlanır
    //iç içe classlarda private olabilir
    //farklı bir projeden de kullanmak istediğimiz classları public olarak tanımlayabiliriz
    public class Course
    {
        public int Name { get; set; }

        private class NestedClass
        {
             
        }
    }
}
