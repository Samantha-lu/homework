using System;
using System.Collections.Generic;
using System.Text;

namespace homework08
{
    public class Order
    {
        //订单号 商品名称 客户
        public string number,goods,client;
        public Order()
        {
            Console.WriteLine("请输入订单号：");
            number = Console.ReadLine();
            Console.WriteLine("请输入商品名：");
            goods = Console.ReadLine();
            Console.WriteLine("请输入客户名：");
            client = Console.ReadLine();


        }
    }
}
