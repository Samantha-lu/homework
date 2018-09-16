using System;

namespace homework01
{
    class homework01

    {

        static void Main(string[] args)

        {

            string s = "";

            int n1 = 0, n2 = 0;

            Console.Write("输入一个整型乘数：");

            s = Console.ReadLine();

            n1 = Int32.Parse(s);

            Console.Write("输入另一个整型乘数：");

            s = Console.ReadLine();

            n2 = Int32.Parse(s);

            Console.Write("这两个数的乘积是：" + (n1 * n2));



        }

    }
}
