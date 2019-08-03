using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static int op1 = 0;
        public static int op2 = 0;
        public static int res = 0;
        public static char oper = '+';
        public static String temp = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "1";
            t1.Text = temp;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op2 = Int32.Parse(t1.Text); 
            /*else
            { */
                switch (oper)
                {
                    case '+':
                        res = op1 + op2;
                        break;
                    case '-':
                        res = op1 - op2;
                        break;
                    case '/':
                        res = op1 / op2;
                        break;
                    case '*':
                        res = op1 * op2;
                        break;
                    default:
                        res = 0;
                        break;
                }
                String resT = res.ToString();
                t1.Text = resT;
                op1 = 0;
                op2 = 0;
                oper = '+';
           // }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            oper = '/';
            //if (!flag)
            //{
                op1 = Int32.Parse(t1.Text);
                t1.Text = "";
                //flag = true;
            //}

        }

        private void button15_Click(object sender, EventArgs e)
        {
            oper = '-';
            //if (!flag)
            //{
                op1 = Int32.Parse(t1.Text);
                t1.Text = "";
               // flag = true;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "2";
            t1.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "3";
            t1.Text = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "4";
            t1.Text = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "5";
            t1.Text = temp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "6";
            t1.Text = temp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "7";
            t1.Text = temp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "8";
            t1.Text = temp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "9";
            t1.Text = temp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            temp = temp + "0";
            t1.Text = temp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temp = t1.Text;
            String temp2 = t1.Text;
            int len = temp.Length;
            temp = temp.Substring(0, len - 1);
            t1.Text = temp;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oper = '+';
            //if (!flag)
            //{
                op1 = Int32.Parse(t1.Text);
                t1.Text = "";
                //flag = true;
            //}
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oper = '*';
            //if (!flag)
            //{
                op1 = Int32.Parse(t1.Text);
                t1.Text = "";
                //flag = true;
            //}
        }

        private void button18_Click(object sender, EventArgs e)
        {
            oper = 's';
            int tempI = Int32.Parse(t1.Text);
            double resD = (double)tempI;
            resD = Math.Sin(resD);
            t1.Text = resD.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            oper = 'c';
            int tempI = Int32.Parse(t1.Text);
            double resD = (double)tempI;
            resD = Math.Cos(resD);
            t1.Text = resD.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            oper = 't';
            int tempI = Int32.Parse(t1.Text);
            double resD = (double)tempI;
            resD = Math.Tan(resD);
            t1.Text = resD.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            oper = 'r';
            int tempI = Int32.Parse(t1.Text);
            double resD = (double)tempI;
            resD = Math.Sqrt(resD);
            t1.Text = resD.ToString();
        }
    }
}
