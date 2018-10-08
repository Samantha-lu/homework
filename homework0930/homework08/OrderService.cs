using System;
using System.Collections.Generic;
using System.Text;

namespace homework08
{
    public class OrderService
    {
        //创建一个List储存订单数据
        public static List<Order> DataList = new List<Order>();
        // 添加订单、删除订单、修改订单、查询订单
        public void AddOrder(Order newOrder)//添加
        {
            DataList.Add(newOrder);//往list中添加一个新订单
        }

        public void SearchOrder()//按照订单号、商品名称、客户等字段进行查询
        {
            Console.WriteLine("请输入查询方式（1：订单号 2：商品名 3：客户名）：");
            int nflag = Convert.ToInt32(Console.ReadLine());
            switch (nflag)//按不同方式查找
            {
                case 1:
                    SearchOrderByNumber();
                    break;
                case 2:
                    SearchOrderByGoods();
                    break;
                case 3:
                    SearchOrderByClient();
                    break;
                default:
                    Console.WriteLine("输入有误！");
                    break;
            }
        }
        public void SearchOrderByNumber()//按订单号查找
        {
            Console.WriteLine("请输入订单号：");
            string keywords = Console.ReadLine();//输入关键字
            for (int i = 1; i < DataList.Count; i++)
            {
                bool k = true;
                if (keywords == DataList[i].number)
                {
                    Console.WriteLine("订单号为" + keywords + "的订单商品为" + DataList[i].goods + "、客户为" + DataList[i].client);
                    k = false;
                }
                if (k)
                {
                    Console.WriteLine("未找到该订单！");
                }
            }
        }
        public void SearchOrderByGoods()//按商品查找
        {
            Console.WriteLine("请输入商品名：");
            string keywords = Console.ReadLine();//输入关键字
            for (int i = 1; i < DataList.Count; i++)
            {
                bool k = true;
                if (keywords == DataList[i].goods)
                {
                    Console.WriteLine("商品为" + keywords + "的订单单号为" + DataList[i].number + "、客户为" + DataList[i].client);
                    k = false;
                }
                if (k)
                {
                    Console.WriteLine("未找到该订单！");
                }
            }
        }
        public void SearchOrderByClient()//按客户查找
        {
            Console.WriteLine("请输入商品名：");
            string keywords = Console.ReadLine();//输入关键字
            for (int i = 1; i < DataList.Count; i++)
            {
                bool k = true;
                if (keywords == DataList[i].client)
                {
                    Console.WriteLine("客户为" + keywords + "的订单单号为" + DataList[i].number + "、商品为" + DataList[i].goods);
                    k = false;
                }
                if (k)
                {
                    Console.WriteLine("未找到该订单！");
                }
            }
        }

        public void DeleteOrder()//按照订单号、商品名称、客户等字段进行删除
        {
            Console.WriteLine("请输入删除方式（1：订单号 2：商品名 3：客户名）：");
            int nflag = Convert.ToInt32(Console.ReadLine());
            switch (nflag)
            {
                case 1:
                    DeleteOrderByNumber();
                    break;
                case 2:
                    DeleteOrderByGoods();
                    break;
                case 3:
                    DeleteOrderByClient();
                    break;
                default:
                    Console.WriteLine("输入有误！");
                    break;
            }
        }
        public void DeleteOrderByNumber()//按订单号删除
        {
            Console.WriteLine("请输入订单号：");
            string keywords = Console.ReadLine();//输入关键字
            for (int i = 1; i < DataList.Count; i++)
            {
                bool k = true;
                if (keywords == DataList[i].number)
                {
                    DataList.Remove(DataList[i]);
                    k = false;
                }
                if (k)
                {
                    Console.WriteLine("未找到该订单！");
                }
            }
        }
        public void DeleteOrderByGoods()//按商品删除
        {
            Console.WriteLine("请输入商品名：");
            string keywords = Console.ReadLine();//输入关键字
            bool k = true;
            for (int i = 1; i < DataList.Count; i++)
            {
                if (keywords == DataList[i].goods)
                {
                    DataList.Remove(DataList[i]);
                    k = false;
                }

            }
            if (k)
            {
                Console.WriteLine("未找到该订单！");
            }
        }
        public void DeleteOrderByClient()//按客户删除
        {
            Console.WriteLine("请输入商品名：");
            string keywords = Console.ReadLine();//输入关键字
            bool k = true;
            for (int i = 1; i < DataList.Count; i++)
            {
                if (keywords == DataList[i].client)
                {
                    DataList.Remove(DataList[i]);
                    k = false;
                }
            }
            if (k)
            {
                Console.WriteLine("未找到该订单！");
            }
        }

        public void AlterOrder()//修改订单
        {
            Console.WriteLine("请要修改的内容（1：订单号 2：商品名 3：客户名）：");
            int nflag = Convert.ToInt32(Console.ReadLine());
            switch (nflag)
            {
                case 1:
                    AlterOrderByNumber();
                    break;
                case 2:
                    AlterOrderByGoods();
                    break;
                case 3:
                    AlterOrderByClient();
                    break;
                default:
                    Console.WriteLine("输入有误！");
                    break;
            }
        }
        public void AlterOrderByNumber()//按订单号删除
        {
            Console.WriteLine("请输入要修改的订单号：");
            string keywords = Console.ReadLine();//输入关键字
            for (int i = 1; i < DataList.Count; i++)
            {
                bool k = true;
                if (keywords == DataList[i].number)
                {
                    Console.WriteLine("请修改后的订单号：");
                    string newNumber = Console.ReadLine();
                    DataList[i].number=newNumber;
                    k = false;
                }
                if (k)
                {
                    Console.WriteLine("未找到该订单！");
                }
            }
        }
        public void AlterOrderByGoods()//按商品修改
        {
            Console.WriteLine("请输入商品名：");
            string keywords = Console.ReadLine();//输入关键字
            bool k = true;
            for (int i = 1; i < DataList.Count; i++)
            {
                if (keywords == DataList[i].goods)
                {
                    Console.WriteLine("请修改后的订单号：");
                    string newGoods = Console.ReadLine();
                    DataList[i].goods = newGoods;
                    k = false;
                }

            }
            if (k)
            {
                Console.WriteLine("未找到该订单！");
            }
        }
        public void AlterOrderByClient()//按客户修改
        {
            Console.WriteLine("请输入要修改的客户名：");
            string keywords = Console.ReadLine();//输入关键字
            bool k = true;
            for (int i = 1; i < DataList.Count; i++)
            {
                if (keywords == DataList[i].client)
                {
                    Console.WriteLine("请修改后的客户名：");
                    string newNumber = Console.ReadLine();
                    DataList[i].number = newNumber;
                    k = false;
                }
            }
            if (k)
            {
                Console.WriteLine("未找到该订单！");
            }
        }



    }
    
}
