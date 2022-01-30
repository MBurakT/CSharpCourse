using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // default parametreden sonra normal parametre olmalılı, default parametreler sonda olmalı
            // ref ile gönderilen parametreye başlangıç değeri verilmelidir, out ile gönderilende böyle bir zorunluluk yok
            // out ile gönderilen parametre methodun içinde set edilmelidir.
            // params ile dizi formatında parametre gönderebiliriz ve params en son parametre olmalı

            //var result = Add3(out number1, number2);
            Console.WriteLine(Add4(2, 4, 26, 8, 10));

            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        //Default parametreler en sonda olmalı
        static int Add2(int number1 = 20, int number2 = 30)
        {
            return number1 + number2;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(int number1, params int[] numbers)
        {
            return number1 + numbers.Sum();
        }
    }
}
