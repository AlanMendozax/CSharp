using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrithView
{
    public partial class Form1 : Form
    {
        DataTable directorio = new DataTable();
        public Form1()
        {
            InitializeComponent();
            directorio.Columns.Add("Contacto");
            directorio.Columns.Add("Número");
            directorio.Columns.Add("E-mail");
            directorio.Rows.Add(new object[] { "Jose", "1(234)567-8910", "easd@hotmail.com" });
            directorio.Rows.Add(new object[] { "Miriam", "1(234)567-8910", "easd@hotmail.com" });
            directorio.Rows.Add(new object[] { "Josélito", "1(234)567-8910", "easd@hotmail.com" });
            Tablita.DataSource = directorio;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tablita.Columns.Add("nombre","Nombre");
            //Tablita.Columns.Add("apellido", "Apellido");
            //Tablita.Columns.Add("telefono", "Telefono");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            directorio.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            directorio.DefaultView.RowFilter = $"Contacto LIKE '{textBox4.Text}%'";
        }
    }
}
