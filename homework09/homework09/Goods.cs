using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
 
    class Goods//货物
    {
        private double price;//货物价格

        public uint Id { get; set; }//商品号

        public string Name { get; set; }//商品名

        public Goods(uint id, string name, double value)//构造一个函数
        {
            Id = id;
            Name = name;
            Price = value;
        }

        public double Price//属性:价格
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }
        
        public override string ToString()//重写ToString方法
        {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }
    }
}
