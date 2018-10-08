using System;

namespace homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();//实例化事件发布者及订阅者：clock
            clock.Ranging += clock.Clockranging;//订阅事件
            clock.Keeptime();  //引发事件：开始计时
        }
    }
}
