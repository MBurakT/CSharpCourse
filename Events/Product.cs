using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //Event'ler aslında bir delegate'tir, delegate'lerin kullanımıyla yapabileceğimiz bir işlemdir
    public delegate void StockControl();
    public class Product
    {
        //Normalde veritabanından çekilir
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} stock amount : {0}", Stock, ProductName);
        }
    }
}
