using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            IEat[] eaters = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            Console.WriteLine();

            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            Console.WriteLine();

            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Manager Worked");
        }
        public void Eat()
        {
            Console.WriteLine("Manager Ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Got");
        }
    }

    class Worker : IWorker, IEat, IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Worker Worked");
        }
        public void Eat()
        {
            Console.WriteLine("Worker Ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Got");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Worked");
        }
    }
}
