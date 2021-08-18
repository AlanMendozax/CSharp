using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurso29112018
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        //Variables
        public bool DecisionTomada = false;

        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está segur@ de que desea cancelar el Registro? \n Se perderán los datos no guardados", "Cerrando...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //El formulario se cerrará.
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}