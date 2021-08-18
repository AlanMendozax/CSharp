using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TareaGrafos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            if (x == 1) {
                
                g.DrawEllipse(Pens.Green, 100, 20, 30, 30); //a
                label1.Visible = true;
                g.DrawLine(Pens.Black, new Point(100, 42), new Point(60, 78)); //1
                label2.Visible = true;
                g.DrawEllipse(Pens.Green, 40, 79, 30, 30);//b
                label4.Visible = true;
            }
            if (x==2) {
                
                g.DrawLine(Pens.Black, new Point(130, 42), new Point(170, 78)); //2
                label3.Visible = true;
                g.DrawEllipse(Pens.Green, 160, 79, 30, 30); //d
                label5.Visible = true;
            }
           
            if (x == 3)
            {
                g.DrawLine(Pens.Black, new Point(54, 109), new Point(67, 143)); //3
                label6.Visible = true;
                g.DrawEllipse(Pens.Green, 65, 138, 30, 30); //c
                label7.Visible = true;
            }
            
            if (x== 4) {
                g.DrawLine(Pens.Black, new Point(89, 165), new Point(135, 165)); //4
                label8.Visible = true;
                g.DrawEllipse(Pens.Green, 130, 138, 30, 30); //e
                label9.Visible = true;
            }
            
            if (x == 5) {
                g.DrawLine(Pens.Black, new Point(170, 109), new Point(155, 140)); //5
                label10.Visible = true;
            }
      
            label11.Text = (x++).ToString();
            if (x == 5) { label12.Text = "Han pasado 5 segundos"; }
            if (x == 8) { label13.Text = "Han pasado 8 segundos"; }
            if (x == 9) { label14.Text = "Han pasado 9 segundos"; }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
