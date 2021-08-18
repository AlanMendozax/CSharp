using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MiDLL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirDLL
{
    public partial class Form1 : Form
    {
        int p;
        int s;
        string o;
        public Form1()
        {
            InitializeComponent();
        }
         Class1 x = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            o = "+";
            p = Int32.Parse(textBox1.Text);
            textBox1.Clear();
             
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            o = "-";
            p = Int32.Parse(textBox1.Text);
            textBox1.Clear();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            o = "/";
            p = Int32.Parse(textBox1.Text);
            textBox1.Clear();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            o = "*";
            p = Int32.Parse(textBox1.Text);
            textBox1.Clear();
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s= Int32.Parse(textBox1.Text);
            int sum;
            int res;
            int div;
            int mul;
            switch (o) {
                case "+":
                    sum = x.Suma(p, s);
                    textBox1.Text = sum.ToString();
                    break;
                case "-":
                    res = x.Resta(p, s);
                    textBox1.Text = res.ToString();
                    break;
                case "/":
                    div = x.Division(p, s);
                    textBox1.Text = div.ToString();
                    break;
                case "*":
                    mul = x.Multiplicacion(p, s);
                    textBox1.Text = mul.ToString();
                    break;


            }
        }
    }
}
