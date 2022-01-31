using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            Customer customer = new Customer();
            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Fkymon", LastName = "Turhan"
            };


            customer.City = "Bilecik";
            customer.Id = 1;
            customer.FirstName = "Burak";
            customer.LastName = "Turhan";

            Console.WriteLine(customer.Id+"\\'o.o'/"+customer.FirstName + "\\'o.o'/" + customer.LastName + "\\'o.o'/" + customer.City);
            customerManager.Add();
            customerManager.Update();
            productManager .Add();
            productManager.Update();

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }
}
