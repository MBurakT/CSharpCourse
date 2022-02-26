using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //ActionDemo();

            //Func bir şey döndürmek zorunda, Action ise void döndürür
            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 4));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            //2 saniye bekle
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundException recordNotFoundException)
            {
                Console.WriteLine(recordNotFoundException.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Burak", "Fobon", "Fkymon" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3]
                {
                "Burak", "Fobon", "Fkymon"
                };

                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}