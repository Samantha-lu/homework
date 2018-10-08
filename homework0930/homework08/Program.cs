using System;

namespace homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService myService = new OrderService();
            Order books = new Order();
            myService.AddOrder(books);
            myService.AlterOrder();
            myService.DeleteOrder();
            myService.SearchOrder();

        }
    }

}
