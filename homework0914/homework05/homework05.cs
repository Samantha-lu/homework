using System;

namespace homework05
{
    class homework05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2到100间的素数有：");
            for (int i=2; i<100; i++ )
            {
                for (int j =2;j<=i;j++)
                {
                    if (i % j == 0&&j<i) break;//能被整除时结束循环
                    if (i % j != 0) continue;
                    else Console.WriteLine(i);
                }
                
            }        
        }
    }
}
