using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product() : this("未知品項", 60)
        {
        }

        public int Price//語法糖
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 100)
                    price = 100;
                else if (value < 50)
                    price = 50;
                else
                    price = value;
            }
        }

        public string Name//2017版visual Studio 有Lambda表示法 get => name; set =>name;
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}