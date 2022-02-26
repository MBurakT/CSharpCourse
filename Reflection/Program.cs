using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reflection çalışma anında kullanacak nesnelerin belirlenmesi için kullanılır
            //Gerektiği kullanılması gerekir, her şeyin çalışma anında belirlenmesi yanlış olur ve ufak da olsa performans kaybına yol açar
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);

            //Çalışma anında dinamik olarak instance(örnek/new) oluşturuyoruz
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 6, 7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine("Method Name: " + method.Name);
                foreach (var parameterInfo in method.GetParameters())
                {
                    Console.WriteLine("Parametre: " + parameterInfo.Name);
                }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: " + attribute.GetType());
                }
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {

        }

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
