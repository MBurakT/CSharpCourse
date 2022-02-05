using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
                customerDal.Update();
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Student student = new Student
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Turhan",
                Departmant = "Faculty of Engineer"
            };

            personManager.Add(new Customer { Id = 1, FirstName = "Fkymon", LastName = "Sky", Address = "İstanbul" });
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        //Interface değişken veya method yazılırken sadece imzası yazılır.(public, private vs. yazılmaz)
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id + ", " + person.FirstName + ", " + person.LastName);
        }
    }
}
