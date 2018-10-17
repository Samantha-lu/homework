using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
       class Customer//顾客
    {
        public uint Id { get; set; }//顾客ID
        
        public string Name { get; set; }//顾客姓名
        
        public Customer(uint id, string name)//构造函数创建一个顾客
        {
            this.Id = id;
            this.Name = name;
        }
        
        public override string ToString()
        {
            return $"customerId:{Id}, CustomerName:{Name}";
        }


    }
}
