using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArbolesExp
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();         
        }

        int s;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            limpieza();
            timer2.Enabled = true;
            timer2.Start();            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s++;
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            Font x = new Font("Arial", 12);
            SolidBrush w = new SolidBrush(Color.Red);
            if (s == 1)
            {
                g.DrawEllipse(Pens.Green, 300, 2, 30, 30);
                g.DrawString("*", x, w, 305, 5);
            }

            if (s == 2)
            {
                g.DrawLine(Pens.Black, new Point(305, 28), new Point(280, 57));
                g.DrawEllipse(Pens.Green, 250, 50, 30, 30);
                g.DrawString("+", x, w, 255, 55);
            }

            if (s == 3)
            {
                g.DrawLine(Pens.Black, new Point(328, 25), new Point(355, 53));
                g.DrawEllipse(Pens.Green, 350, 50, 30, 30);
                g.DrawString("*", x, w, 355, 55);
            }

            if (s == 4)
            {
                g.DrawLine(Pens.Black, new Point(255, 77), new Point(220, 100)); 
                g.DrawEllipse(Pens.Green, 205, 100, 30, 30);
                g.DrawString("A", x, w, 210, 105);
            }

            if (s == 5)
            {
                g.DrawLine(Pens.Black, new Point(275, 77), new Point(290, 100));
                g.DrawEllipse(Pens.Green, 275, 100, 30, 30);
                g.DrawString("B", x, w, 280, 105);
            }

            if (s == 6)
            {
                g.DrawLine(Pens.Black, new Point(355, 77), new Point(335, 100));
                g.DrawEllipse(Pens.Green, 325, 100, 30, 30);
                g.DrawString("C", x, w, 330, 105);
            }

            if (s == 7)
            {
                g.DrawLine(Pens.Black, new Point(375, 77), new Point(400, 102));
                g.DrawEllipse(Pens.Green, 395, 100, 30, 30);
                g.DrawString("-", x, w, 405, 105);
            }

            if (s == 8)
            {
                g.DrawLine(Pens.Black, new Point(410, 130), new Point(410, 150));
                g.DrawEllipse(Pens.Green, 395, 150, 30, 30);
                g.DrawString("+", x, w, 400, 155);
            }

            if (s == 9)
            {
                g.DrawLine(Pens.Black, new Point(400, 177), new Point(385, 200));
                g.DrawEllipse(Pens.Green, 365, 200, 30, 30);
                g.DrawString("C", x, w, 370, 205);
            }

            if (s == 10)
            {
                g.DrawLine(Pens.Black, new Point(425, 172), new Point(445, 200));
                g.DrawEllipse(Pens.Green, 435, 200, 30, 30);
                g.DrawString("D", x, w, 440, 205);
            }            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          limpieza();
          timer1.Enabled = true;
          timer1.Start();          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            limpieza();
            timer3.Enabled = true;
            timer3.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            limpieza();
            timer4.Enabled = true;
            timer4.Start();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            limpieza();
            timer5.Enabled = true;
            timer5.Start();
        }

        private void limpieza()
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer2.Enabled = false;
            timer2.Stop();
            timer3.Enabled = false;
            timer3.Stop();
            timer4.Enabled = false;
            timer4.Stop();
            timer5.Enabled = false;
            timer5.Stop();
            pictureBox1.Image = null;
            s = 0;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            s++;
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            Font x = new Font("Arial", 12);
            SolidBrush w = new SolidBrush(Color.Red);
            if (s == 1)
            {
                g.DrawEllipse(Pens.Green, 300, 0, 34, 34);
                g.DrawString("Sen", x, w, 300, 5);
            }

            if (s == 2)
            {
                g.DrawLine(Pens.Black, new Point(305, 31), new Point(280, 57));
                g.DrawEllipse(Pens.Green, 250, 50, 30, 30);
                g.DrawString("*", x, w, 255, 55);
            }

            if (s == 3)
            {
                g.DrawLine(Pens.Black, new Point(328, 31), new Point(355, 53));
                g.DrawEllipse(Pens.Green, 350, 50, 30, 30);
                g.DrawString("*", x, w, 355, 55);
            }

            if (s == 4)
            {
                g.DrawLine(Pens.Black, new Point(255, 77), new Point(220, 100));
                g.DrawEllipse(Pens.Green, 205, 100, 30, 30);
                g.DrawString("Q", x, w, 210, 105);
            }

            if (s == 5)
            {
                g.DrawLine(Pens.Black, new Point(275, 77), new Point(290, 100));
                g.DrawEllipse(Pens.Green, 275, 100, 30, 30);
                g.DrawString("+", x, w, 280, 105);
            }

            if (s == 6)
            {
                g.DrawLine(Pens.Black, new Point(355, 77), new Point(335, 100));
                g.DrawEllipse(Pens.Green, 325, 100, 30, 30);
                g.DrawString("C", x, w, 330, 105);
            }

            if (s == 7)
            {
                g.DrawLine(Pens.Black, new Point(375, 77), new Point(400, 102));
                g.DrawEllipse(Pens.Green, 395, 100, 30, 30);
                g.DrawString("+", x, w, 405, 105);
            }

            if (s == 8)
            {
                g.DrawLine(Pens.Black, new Point(415, 130), new Point(430, 151));
                g.DrawEllipse(Pens.Green, 420, 150, 30, 30);
                g.DrawString("+", x, w, 425, 155);
            }

            if (s == 9)
            {
                g.DrawLine(Pens.Black, new Point(405, 130), new Point(385, 149));
                g.DrawEllipse(Pens.Green, 370, 150, 30, 30);
                g.DrawString("X", x, w, 375, 155);
            }

            if (s == 10)
            {
                g.DrawLine(Pens.Black, new Point(280, 128), new Point(265, 150));
                g.DrawEllipse(Pens.Green, 250, 150, 30, 30);
                g.DrawString("A", x, w, 255, 155);
            }

            if (s == 11)
            {
                g.DrawLine(Pens.Black, new Point(295, 130), new Point(305, 149));
                g.DrawEllipse(Pens.Green, 295, 150, 30, 30);
                g.DrawString("B", x, w, 300, 155);
            }

            if (s == 12)
            {
                g.DrawLine(Pens.Black, new Point(425, 177), new Point(390, 200));
                g.DrawEllipse(Pens.Green, 380, 200, 30, 30);
                g.DrawString("Y", x, w, 385, 205);
            }

            if (s == 13)
            {
                g.DrawLine(Pens.Black, new Point(443, 177), new Point(460, 200));
                g.DrawEllipse(Pens.Green, 450, 200, 30, 30);
                g.DrawString("Z", x, w, 455, 205);
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            s++;
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            Font x = new Font("Arial", 12);
            SolidBrush w = new SolidBrush(Color.Red);
            if (s == 1)
            {
                g.DrawEllipse(Pens.Green, 300, 0, 30, 30);
                g.DrawString("+", x, w, 305, 5);
            }

            if (s == 2)
            {
                g.DrawLine(Pens.Black, new Point(305, 27), new Point(255, 54));
                g.DrawEllipse(Pens.Green, 230, 50, 30, 30);
                g.DrawString("-", x, w, 238, 55);
            }

            if (s == 3)
            {
                g.DrawLine(Pens.Black, new Point(325, 27), new Point(375, 57));
                g.DrawEllipse(Pens.Green, 375, 50, 30, 30);
                g.DrawString("+", x, w, 380, 55);
            }

            if (s == 4)
            {
                g.DrawLine(Pens.Black, new Point(235, 77), new Point(200, 100));
                g.DrawEllipse(Pens.Green, 185, 100, 30, 30);
                g.DrawString("3", x, w, 190, 105);
            }

            if (s == 5)
            {
                g.DrawLine(Pens.Black, new Point(250, 81), new Point(260, 100));
                g.DrawEllipse(Pens.Green, 245, 100, 30, 30);
                g.DrawString("*", x, w, 250, 105);
            }

            if (s == 6)
            {
                g.DrawLine(Pens.Black, new Point(375, 70), new Point(355, 100));
                g.DrawEllipse(Pens.Green, 345, 100, 30, 30);
                g.DrawString("-", x, w, 350, 105);
            }

            if (s == 7)
            {
                g.DrawLine(Pens.Black, new Point(405, 72), new Point(430, 102));
                g.DrawEllipse(Pens.Green, 425, 100, 30, 30);
                g.DrawString("+", x, w, 435, 105);
            }

            if (s == 8)
            {
                g.DrawLine(Pens.Black, new Point(455, 120), new Point(475, 151));
                g.DrawEllipse(Pens.Green, 465, 150, 30, 30);
                g.DrawString("X", x, w, 470, 155);
            }

            if (s == 9)
            {
                g.DrawLine(Pens.Black, new Point(435, 130), new Point(427, 149));
                g.DrawEllipse(Pens.Green, 415, 150, 30, 30);
                g.DrawString("3", x, w, 420, 155);
            }

            if (s == 10)
            {
                g.DrawLine(Pens.Black, new Point(250, 128), new Point(235, 150));
                g.DrawEllipse(Pens.Green, 220, 150, 30, 30);
                g.DrawString("2", x, w, 225, 155);
            }

            if (s == 11)
            {
                g.DrawLine(Pens.Black, new Point(265, 130), new Point(275, 149));
                g.DrawEllipse(Pens.Green, 265, 150, 30, 30);
                g.DrawString("X", x, w, 270, 155);
            }

            if (s == 12)
            {
                g.DrawLine(Pens.Black, new Point(365, 130), new Point(385, 151));
                g.DrawEllipse(Pens.Green, 375, 150, 30, 30);
                g.DrawString("2", x, w, 380, 155);
            }

            if (s == 13)
            {
                g.DrawLine(Pens.Black, new Point(350, 128), new Point(337, 149));
                g.DrawEllipse(Pens.Green, 325, 150, 30, 30);
                g.DrawString("X", x, w, 330, 155);
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            s++;
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            Font x = new Font("Arial", 12);
            SolidBrush w = new SolidBrush(Color.Red);
            if (s == 1)
            {
                g.DrawEllipse(Pens.Green, 300, 3, 30, 30);
                g.DrawString("^", x, w, 305, 7);
            }

            if (s == 2)
            {
                g.DrawLine(Pens.Black, new Point(305, 31), new Point(280, 57));
                g.DrawEllipse(Pens.Green, 250, 50, 30, 30);
                g.DrawString("*", x, w, 258, 55);
            }

            if (s == 3)
            {
                g.DrawLine(Pens.Black, new Point(328, 28), new Point(355, 53));
                g.DrawEllipse(Pens.Green, 350, 50, 30, 30);
                g.DrawString("+", x, w, 355, 55);
            }

            if (s == 4)
            {
                g.DrawLine(Pens.Black, new Point(255, 77), new Point(220, 100));
                g.DrawEllipse(Pens.Green, 205, 100, 30, 30);
                g.DrawString("x", x, w, 210, 105);
            }

            if (s == 5)
            {
                g.DrawLine(Pens.Black, new Point(275, 77), new Point(290, 100));
                g.DrawEllipse(Pens.Green, 275, 100, 30, 30);
                g.DrawString("-", x, w, 280, 105);
            }

            if (s == 6)
            {
                g.DrawLine(Pens.Black, new Point(355, 77), new Point(335, 100));
                g.DrawEllipse(Pens.Green, 325, 100, 30, 30);
                g.DrawString("Y", x, w, 330, 105);
            }

            if (s == 7)
            {
                g.DrawLine(Pens.Black, new Point(375, 77), new Point(400, 102));
                g.DrawEllipse(Pens.Green, 395, 100, 30, 30);
                g.DrawString("+", x, w, 405, 105);
            }

            if (s == 8)
            {
                g.DrawLine(Pens.Black, new Point(415, 130), new Point(430, 151));
                g.DrawEllipse(Pens.Green, 420, 150, 30, 30);
                g.DrawString("B", x, w, 425, 155);
            }

            if (s == 9)
            {
                g.DrawLine(Pens.Black, new Point(405, 130), new Point(385, 149));
                g.DrawEllipse(Pens.Green, 370, 150, 30, 30);
                g.DrawString("A", x, w, 375, 155);
            }

            if (s == 10)
            {
                g.DrawLine(Pens.Black, new Point(280, 128), new Point(265, 150));
                g.DrawEllipse(Pens.Green, 250, 150, 30, 30);
                g.DrawString("Y", x, w, 255, 155);
            }

            if (s == 11)
            {
                g.DrawLine(Pens.Black, new Point(295, 130), new Point(305, 149));
                g.DrawEllipse(Pens.Green, 295, 150, 30, 30);
                g.DrawString("Z", x, w, 300, 155);
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            s++;
            Bitmap p = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(p, pictureBox1.ClientRectangle);
            pictureBox1.Image = (Image)p;
            Graphics g = Graphics.FromImage(p);
            Font x = new Font("Arial", 12);
            SolidBrush w = new SolidBrush(Color.Red);
            if (s == 1)
            {
                g.DrawEllipse(Pens.Green, 300, 0, 30, 30);
                g.DrawString("+", x, w, 305, 5);
            }

            if (s == 2)
            {
                g.DrawLine(Pens.Black, new Point(305, 27), new Point(255, 54));
                g.DrawEllipse(Pens.Green, 230, 50, 30, 30);
                g.DrawString("+", x, w, 238, 55);
            }

            if (s == 3)
            {
                g.DrawLine(Pens.Black, new Point(325, 27), new Point(375, 57));
                g.DrawEllipse(Pens.Green, 375, 50, 30, 30);
                g.DrawString("^", x, w, 380, 55);
            }

            if (s == 4)
            {
                g.DrawLine(Pens.Black, new Point(235, 77), new Point(200, 100));
                g.DrawEllipse(Pens.Green, 185, 100, 30, 30);
                g.DrawString("A", x, w, 190, 105);
            }

            if (s == 5)
            {
                g.DrawLine(Pens.Black, new Point(250, 81), new Point(260, 100));
                g.DrawEllipse(Pens.Green, 245, 100, 30, 30);
                g.DrawString("B", x, w, 250, 105);
            }

            if (s == 6)
            {
                g.DrawLine(Pens.Black, new Point(375, 70), new Point(355, 100));
                g.DrawEllipse(Pens.Green, 345, 100, 30, 30);
                g.DrawString("/", x, w, 350, 105);
            }

            if (s == 7)
            {
                g.DrawLine(Pens.Black, new Point(405, 72), new Point(430, 102));
                g.DrawEllipse(Pens.Green, 425, 100, 34, 34);
                g.DrawString("3.5.", x, w, 427, 107);
            }

            if (s == 8)
            {
                g.DrawLine(Pens.Black, new Point(365, 130), new Point(385, 151));
                g.DrawEllipse(Pens.Green, 375, 150, 30, 30);
                g.DrawString("D", x, w, 380, 155);
            }

            if (s == 9)
            {
                g.DrawLine(Pens.Black, new Point(350, 128), new Point(337, 149));
                g.DrawEllipse(Pens.Green, 325, 150, 30, 30);
                g.DrawString("C", x, w, 330, 155);
            }
        }
    }
}
