using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "My name is fkymon";
            bool result = sentence.EndsWith("n");
            bool result2 = sentence.StartsWith("my name");
            var result3 = sentence.IndexOf("name");
            var result4 = sentence.IndexOf(" ");
            var result5 = sentence.LastIndexOf(" ");
            var result6 = sentence.Insert(0, "Hello! ");
            var result7 = sentence.Substring(11);
            var result8 = sentence.Replace(" ", "-");
            var result9 = sentence.Remove(2, 5);

            Console.Write(sentence.Length + ", " + sentence + ", " + result + ", " + result2 + ", " + result3 + ", " + result4 + ", " + result5);
            Console.WriteLine(", " + result6 + ", " + result7 + ", " + result8);
            Console.WriteLine(result9);

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();

        }
    }
}
