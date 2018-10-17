using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ordertest
{
    class OrderService
    {
        private Dictionary<uint, Order> orderDict;//Dictionary类
       
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }

       
        public void AddOrder(Order order)//添加订单
        {
            if (orderDict.ContainsKey(order.Id))//如果已有订单
                throw new Exception($"order-{order.Id} is already existed!");
            orderDict[order.Id] = order;
        }
        
        public void RemoveOrder(uint orderId)//取消订单
        {
            orderDict.Remove(orderId);//移除
        }

        public List<Order> QueryAllOrders()//查询所有订单
        {
            return orderDict.Values.ToList();
        }

       
        public Order GetById(uint orderId)//通过订单号查询订单
        {
            return orderDict[orderId];
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

       
        public List<Order> QueryByCustomerName(string customerName)//通过顾客名查询
        {
            var query = orderDict.Values.Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

         
        public void UpdateCustomer(uint orderId, Customer newCustomer)//更新客户信息
        {
            if (orderDict.ContainsKey(orderId))//按订单号查找到订单
            {
                orderDict[orderId].Customer = newCustomer;
            }
            else
            {
                throw new Exception($"order-{orderId} is not existed!");
            }
        }
        
    }
}

}
