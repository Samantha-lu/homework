using System;

namespace homework03
{
    class homework03
    {
       static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数：");
            string sNum = Console.ReadLine();
            int testNum = Int32.Parse(sNum) ;
            Console.WriteLine(sNum + "的素数因子有:");           
            findFirstNum();
            void findFirstNum()//每次找到最小的因子
            {
             
                for (int j = 2; j <= testNum; j++)
                {
                    if (testNum % j != 0) continue;
                    if (testNum % j == 0)
                    {                        
                        Console.WriteLine(j);
                        testNum = testNum / j;//将所求数按当前因子分解
                        findFirstNum();//递归调用         
                    }                 
                }
            }
           
        }
    }
}
