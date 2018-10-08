using System;
using System.Collections.Generic;
using System.Text;

namespace homework07
{
    public delegate void Clockeventhandler();//声明一个委托

    //定义事件源（闹钟定时）
    public class Clock
    {
        public event Clockeventhandler Ranging;//声明一个事件：响铃

        public int hour, minute, second;
        public Clock()//初始化闹钟
        {
            //设定闹钟时间
            Console.WriteLine("请输入设定的闹钟时间:");
            int h, m, s;
            Console.WriteLine("时：");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("分：");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("秒：");
            s = Convert.ToInt32(Console.ReadLine());
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
      
        public void Keeptime()//闹钟计时
        {
            while(true)
            {
                int nh = DateTime.Now.Hour;
                int nm = DateTime.Now.Minute;
                int ns = DateTime.Now.Second;
                if (nh==this.hour&&nm==this.minute&&ns==this.second)
                {
                    Ranging();
                    break;
                }
            }
           

        }
       public void Clockranging()
        {
            Console.WriteLine("铃铃铃——");
        }

    }

    
    

}
