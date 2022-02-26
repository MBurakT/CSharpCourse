using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                if (harddisk.Stock < 1 || gsm.Stock < 1)
                {
                    break;
                }
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            // Do Not Auto Close, Write Code Executed İnfo, Enter Something To Close
            Console.WriteLine("#Kod çalıştı#");
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            MessageBox.Show("Gsm about to finish!!!");
        }
    }
}
