using System;

namespace homework04
{
    class homwork04
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度");
            string sLen = Console.ReadLine();
            int len = Convert.ToInt32(sLen);
            int[] numbers = new int[len];
            Console.WriteLine("请依次输入数组:");           
            for(int i = 0; i < len; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }            
            int max=numbers[0], min = numbers[0], sum=0;
            double ave;
            for(int i=0; i<len; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                if (numbers[i] < min) min = numbers[i];
                sum = sum + numbers[i];         
            }
            ave = sum / numbers.Length;
            Console.WriteLine("数组中的最大值为" + max + ",最小值为" + min + "，平均数为" + ave + "，和为" + sum);
        }
    }
}
