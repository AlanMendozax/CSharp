using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiClase;

namespace Combo_y_textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 x = new Class1();
            comboBox1.Items.Add(x.ybt(textBox1.Text));
            textBox1.Focus();
            textBox1.Clear();
        }
    }
}
