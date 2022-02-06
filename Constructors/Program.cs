using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");
            Product product3 = new Product();

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //static classları kullanırken instance(new) üretmeden kullanmamız gerekiyor
            //Sunucu belleğinde saklandığı için ortak kullınıma açıktır ve herkes için aynı değeri verir
            //Genellikle static classlardan uzak duramya çalışırız
            Teacher.Number = 10;
            Utilities.Validate();
            //static olmayan classlarda static methodu direkt class üzerinden çağırabiliriz
            Manager.DoSomething();
            //static olmayan classlarda static olmayan methodu instance(new) üzerinden çağırırız
            Manager manager = new Manager();
            manager.DoSomething2();

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        //private bir değişken adı _ ile başlatılır
        private int _count = 15;

        //Bu sınıfın ihtiyaç duyduğu parametreler varsa consturctor kullanılarak alınabilir
        public CustomerManager(int count)
        {
            _count = count;
        }

        //constructorlar overload yapılarak kullanılabilir
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        //Inheritance edildiği sınıfa parametre gönderilmesi base ile
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added to database");
            Message();
        }
    }

    //static classları new ile tanımlayamayız
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            //Mutlaka çalışmasını istediğiniz bir şey varsa buraya konulur
            //Singleton design pattern nedir?
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
