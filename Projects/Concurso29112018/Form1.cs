using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurso29112018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin Accediendo = new FormLogin();
            //Iniciando Login.
            Accediendo.ShowDialog();
            //Comprobar cerrar en Login.
            if(Accediendo.Cerrar == true)
            {
               Close();
            }
        }

        
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin Cerrando = new FormLogin();
            if (Cerrando.Cerrar == true)
            {

            }
            if (Cerrando.Cerrar == false)
            {
                //Confirmar salida.
                if (MessageBox.Show("¿Está segur@ de que desea salir?", "Saliendo...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //El programa se cerrará.
                    MessageBox.Show("Saliendo del programa", "Salida exitosa!", MessageBoxButtons.OK);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxConsultaIdle();          
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            var form = new FormRegistro();
            if (Application.OpenForms[form.Name] == null)
            {
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Focus();
            }
        }

        private void textBoxConsulta_Enter(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBoxConsulta.Text) || textBoxConsulta.Text == "Texto a consultar...")
            {
                textBoxConsulta.ForeColor = Color.Black;
                textBoxConsulta.Text = "";
            }
            else
            {
                textBoxConsulta.ForeColor = Color.Black;
            }
        }

        //Estado desocupado del TextBox
        public void textBoxConsultaIdle()
        {
            textBoxConsulta.ForeColor = Color.Gray;
            textBoxConsulta.Text = "Texto a consultar...";
        }
        private void textBoxConsulta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxConsulta.Text))
            {
                textBoxConsultaIdle();
            }
            else
            {
                textBoxConsulta.ForeColor = Color.Black;
            }
        }

        private void dataGridViewPescadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
