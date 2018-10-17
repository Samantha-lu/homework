using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

  
     public class Order {
        public uint Id { get; set; }//订单号

        public Customer Customer { get; set; }//顾客

        public Order(uint orderId, Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }

        public List<OrderDetail> Details { get; } = new List<OrderDetail>();

        public void AddDetails(OrderDetail orderDetail)
        {
            if (this.Details.Contains(orderDetail))//判断是否为已有订单
            {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            Details.Add(orderDetail);//添加订单细节
        }

        public void RemoveDetails(uint orderDetailId)//移除订单
        {
            Details.RemoveAll(d =>d.Id==orderDetailId);//lambda表达式判断ID是否等于要移除的订单号
        }

        public override string ToString()//重写ToString方法
        {
            string result = "================================================================================\n";
            result += $"orderId:{Id}, customer:({Customer})";
            Details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
