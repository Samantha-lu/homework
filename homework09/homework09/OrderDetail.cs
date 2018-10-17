using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    /// <summary>
    /// OrderDetail class : a entry of an order object
    /// to record the goods and its quantity
    /// </summary>
    class OrderDetail//订单细节
    {
        public uint Id { get; set; }//订单号

        public Goods Goods { get; set; }//货品

        public uint Quantity { get; set; }//数量

        public OrderDetail(uint id, Goods goods, uint quantity)//创建一份订单细节
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }
        
    
        public override bool Equals(object obj)//重写equals方法,比较是否相等
        {
            var detail = obj as OrderDetail;//将obj强制转换为OrderDetail类
            return detail != null 
                &&Goods.Id==detail.Goods.Id
                &&Quantity == detail.Quantity;
        }

        public override int GetHashCode()//重写hashcode
        {
            var hashCode = 1522631281 + Goods.Name.GetHashCode() + Quantity.GetHashCode();
            return hashCode;
        }

        public override string ToString()//重写ToString方法
        {
            string result = "";
            result += $"orderDetailId:{Id}:  ";
            result += Goods + $", quantity:{Quantity}"; 
            return result;
        }


    }
}
