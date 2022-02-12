using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            foreach (var item in dictionary)
            {
                Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }

        private static void List()
        {
            //Veritabanındaki tabloların karşılığı nesne olarak tutulur, Customer tablosu = Customer nesnesi gibi
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Burak" },
                new Customer()
            };

            var customer2 = new Customer
            {
                Id = 2,
                FirstName = "fkymon"
            };

            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 3, FirstName ="Cici"},
                new Customer { Id = 4, FirstName ="Kuş"}
            });

            Console.WriteLine(customers.Contains(customer2));
            //Referans tip olduğu için False değeri döner
            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Burak" }));

            Console.WriteLine("Index: " + customers.IndexOf(customer2));
            customers.Add(customer2);
            Console.WriteLine("Index: " + customers.LastIndexOf(customer2));

            customers.Insert(0, customer2);
            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "fkymon");

            //customers.Clear();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "-" + customer.FirstName);
            }

            Console.WriteLine("Count: " + customers.Count());
        }

        private static void ArrayList()
        {
            //Dinamik Koleksiyon oluşturduk, ArrayList koleksiyon oluşturmak için en temel yollardan birisidir
            //Bütün koleksiyonlar Array bazlıdır, Arrayleri yöneten bir yapı söz konusudur, farklı tipte değişkenleri tutabilir yani tip güvenli değildir
            ArrayList cities = new ArrayList();
            cities.Add("Bilecik");
            cities.Add("Balıkesir");
            cities.Add("İstanbul");
            cities.Add('A');
            cities.Add(11);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
