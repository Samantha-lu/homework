using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homwork06
{
    class homework06
    {
        static void Main(string[] args)
        {
            IChart chart1;
            chart1 = ChartFactory.GetChart("circle"); //通过静态工厂方法创建圆形  
            chart1.Area();
            IChart chart2;
            chart2 = ChartFactory.GetChart("rectangle"); //通过静态工厂方法创建正方形  
            chart2.Area();
            IChart chart3;
            chart3 = ChartFactory.GetChart("rectangle"); //通过静态工厂方法创建长方形  
            chart3.Area();
            IChart chart4;
            chart4 = ChartFactory.GetChart("triangle"); //通过静态工厂方法创建矩形  
            chart4.Area();
        }
    }

    //抽象图表接口：抽象图表产品
    public interface IChart
    {
        void Area();
    }

    //圆形：具体产品类  
    public class CircleChart : IChart
    {
        const double PI = 3.14;
        public double r, s;
        public CircleChart()
        {
            Console.WriteLine("请输入圆形的半径：");
            this.r = Convert.ToDouble(Console.ReadLine());

        }
        public void Area()
        {
            this.s = PI * r * r;
            Console.WriteLine("圆形的面积是：" + s);
        }
    }

    //矩形：具体产品类  
    public class RectangleChart : IChart
    {
        public double a, b, s;
        public RectangleChart()
        {
            Console.WriteLine("请输入矩形的长和宽：");
            this.a = Convert.ToDouble(Console.ReadLine());
            this.b = Convert.ToDouble(Console.ReadLine());

        }
        public void Area()
        {
            this.s = a * b;
            Console.WriteLine("矩形的面积是：" + s);
        }
    }

    //三角形：具体产品类  
    public class TriangleChart : IChart
    {
        public double a, b, c, s;
        public TriangleChart()
        {
            Console.WriteLine("请输入三条边长（要满足两边之和大于第三边）：");
            this.a = Convert.ToDouble(Console.ReadLine());
            this.b = Convert.ToDouble(Console.ReadLine());
            this.c = Convert.ToDouble(Console.ReadLine());

        }
        public void Area()
        {
            double p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("三角形形的面积是：" + s);
        }
    }

    //图表工厂类：工厂类  
    class ChartFactory
    {
        //静态工厂方法  
        public static IChart GetChart(String type)
        {
            IChart chart = null;
            if (type=="circle")
            {
                Console.WriteLine("初始化设置圆形！");
                chart = new CircleChart();
              
            }
            else if (type=="rectangle")
            {
                Console.WriteLine("初始化设置矩形！");
                chart = new RectangleChart();
               
            }
            else if (type=="triangle")
            {
                Console.WriteLine("初始化设置三角形！");
                chart = new TriangleChart();
                
            }
            return chart;
        }
    }

  
}
