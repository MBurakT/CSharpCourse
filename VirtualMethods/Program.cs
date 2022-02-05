using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Add();

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    class Database
    {
        //override etmek istediğimiz methodlara 'virtual' ekleriz
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database
    {
        //base üst sınıfı temsil eder
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            //base.Add();
        }
    }

    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySql");
            base.Add();
        }
    }
}
