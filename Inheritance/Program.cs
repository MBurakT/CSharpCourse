using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Burak"},
                new Student{FirstName="Fobon"},
                new Person{FirstName="Fkymon"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    //Herhangi bir sınıfın sadece 1 tane inheritance'ı olabilirken birden fazla interface'i olabilir
    //Interfacelerden 'new' ile örnek oluşturmak bir anlam ifade etmezken dizi olarak içinde implemente edilmiş olduğu classları tutabilir
    //Implement yapılırken önce inheritance varsa interfaceler yazılır
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
