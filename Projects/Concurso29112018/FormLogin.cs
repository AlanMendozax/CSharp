using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Concurso29112018
{
    public partial class FormLogin : Form
    {
        CNEmpleado objEmpleado = new CNEmpleado();
        private CDConexion Conexion = new CDConexion();

        public FormLogin()
        {
            InitializeComponent();
        }
        //Comprobación para cerrar
        public bool Cerrar = false;
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está segur@ de que desea salir?", "Saliendo...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cerrar = true;
                Close();
            }
            else
            {

            }
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            MySqlDataReader Loguear;
            objEmpleado.Usuario = txtuser.Text;
            objEmpleado.Contraseña = txtpass.Text;
            if (objEmpleado.Usuario == txtuser.Text)
            {
                //lblErrorUs.Visible = false;

                if (objEmpleado.Contraseña == txtpass.Text)
                {
                    //lblErrorPass.Visible = false;
                    Loguear = objEmpleado.IniciarSesion();

                    if (Loguear.Read())
                    {
                        //lblErrorLog.Visible = false;
                        Program.CargoEmpleadoLogueado = Loguear["Cargo"].ToString();
                        Program.NombreEmpleadoLogueado = Loguear["Nombre"].ToString();
                        Program.ApellidosEmpleadoLogueado = Loguear["Apellidos"].ToString();
                        Form1 objFP = new Form1();
                        //RecuperarDatosSesion();
                        objFP.Show();
                        this.Hide();
                    }
                    else
                    {
                        Conexion.Desconectar();
                        //lblErrorLog.Text = "Usuario o contraseña incorrectos, intente de nuevo";
                        //lblErrorLog.Visible = true;
                        txtpass.Text = "";
                        //txtpass_Leave(null, e);
                        txtuser.Focus();
                    }
                }
                else
                {
                    //lblErrorPass.Text = objEmpleado.Contraseña;
                    //lblErrorPass.Visible = true;
                }
            }
            else
            {
                //lblErrorUs.Text = objEmpleado.Usuario;
                //lblErrorUs.Visible = true;
            }
            Cerrar = false;
            Close();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
