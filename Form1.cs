using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        private double x, y, k, m;

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            if (radioButton1.Checked==false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)
            {
                MessageBox.Show("Выберите функцию");
                return;
            }
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox1.Text=="")
            {
                MessageBox.Show("Укажите все параметры");
                return;
            }
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox4.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double x1 = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = x * a + b;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = x * a + b;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton2.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton3.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Cos(x * b) + c;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Cos(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton4.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton5.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        if (Math.Tan(x * b + c) == 0)
                        {
                            x += h;
                        }
                        y = a * (1 / Math.Tan(x * b + c));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        if (Math.Tan(x * b + c) == 0)
                        {
                            x += h;
                        }
                        y = a * (1 / Math.Tan(x * b + c));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton6.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton7.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = Math.Pow(a, x + b);
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = Math.Pow(a, x + b);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (radioButton8.Checked)
            {
                k = -10;
                m = 10;
                x = k;
                while (x <= m)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        if ((x - Math.Pow(x, 0.5)) + 1 == 0)
                        {
                            x += h;
                        }
                        else if (x == 0)
                        {
                            x += h;
                        }
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1), (b / x));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        if ((x - Math.Pow(x, 0.5)) + 1 == 0)
                        {
                            x += h;
                        }
                        else if (x == 0)
                        {
                            x += h;
                        }
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1), (b / x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
        }
    }
}
