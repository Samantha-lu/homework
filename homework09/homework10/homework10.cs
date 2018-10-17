using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace homework1012
{
    public partial class homework10 : Form
    {
        public homework10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            DrawCayleyTree(10, 200, 310, 100, -Math.PI / 2);


        }

        private Graphics graphics;
        static int nflag=0;
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void DrawCayleyTree(int n,double x0,double y0,double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * Math.Cos(th)/2;
            double y2 = y0 + leng * Math.Sin(th)/2;
            Drawline(x0, y0, x1, y1,nflag);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        void  Drawline(double x0,double y0, double x1, double y1,int nflag)
        {
            switch (nflag)
            {
                case 1:
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 2:
                    graphics.DrawLine(Pens.Orange, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 3:
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 4:
                    graphics.DrawLine(Pens.Violet, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 0:
                    graphics.DrawLine(Pens.RosyBrown, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }

            }

      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                 nflag = 1;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                nflag = 2;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nflag = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            nflag = 4;
        }
    }
}
