using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Tienda
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewEmpleados.DataSource = TablaEmpleados.Fill();
            }
        }

        //Linea de comando para sql
        SqlCommand cmd = new SqlCommand();

        private void textBoxEntradaEmpleados_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer.Open();
            cmd.CommandText = "SELECT * FROM dbo.Empleados_Tienda WHERE idEmpleados LIKE '%" + textBoxEntradaEmpleados.Text + "%' " + "OR Nombre LIKE '%" + textBoxEntradaEmpleados.Text + "%' " +
                "OR Telefono LIKE '%" + textBoxEntradaEmpleados.Text + "%' OR Dirección LIKE '%" + textBoxEntradaEmpleados.Text + "%'";
            cmd.Connection = ConexionSQLServer.con;
            SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
            DataTable dtBusqueda = new DataTable();
            daBusqueda.Fill(dtBusqueda);
            dataGridViewEmpleados.DataSource = dtBusqueda;
            dataGridViewEmpleados.Refresh();
        }

        String idEmpleado, Nombre, Telefono, Direccion;

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Eliminar el registro?\nLos registros Eliminados no se pueden volver a recuperar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdEmpleado.Text != "" && textBoxNombre.Text != "" && textBoxTelefono.Text != "" && textBoxDireccion.Text != "")
                {
                    TablaEmpleados.EliminarEmpleados(Convert.ToInt32(textBoxIdEmpleado.Text));
                }
                else
                {
                    MessageBox.Show("¡No puede Eliminar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            dataGridViewEmpleados.DataSource = TablaEmpleados.Fill();
        }

        private void textBoxIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridViewEmpleados_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.RowCount > 0)
            {
                idEmpleado = dataGridViewEmpleados.CurrentRow.Cells[0].Value.ToString();
                Nombre = dataGridViewEmpleados.CurrentRow.Cells[1].Value.ToString();
                Telefono = dataGridViewEmpleados.CurrentRow.Cells[2].Value.ToString();
                Direccion = dataGridViewEmpleados.CurrentRow.Cells[3].Value.ToString();
                textBoxIdEmpleado.Text = idEmpleado;
                textBoxNombre.Text = Nombre;
                textBoxTelefono.Text = Telefono;
                textBoxDireccion.Text = Direccion;
            }
            else
            {

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Modificar el registro?\nLos registros Modificados no se pueden volver a recuperar", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdEmpleado.Text != "" && textBoxNombre.Text != "" && textBoxTelefono.Text != "" && textBoxDireccion.Text != "")
                {
                    TablaEmpleados.ActualizarEmpleados(Convert.ToInt32(textBoxIdEmpleado.Text), textBoxNombre.Text, textBoxTelefono.Text, textBoxDireccion.Text);
                }
                else
                {
                    MessageBox.Show("¡No puede Modificar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            dataGridViewEmpleados.DataSource = TablaEmpleados.Fill();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxIdEmpleado.Text != "" && textBoxNombre.Text != "" && textBoxTelefono.Text != "" && textBoxDireccion.Text != "")
            {
                if (dataGridViewEmpleados.RowCount > 0)
                {
                    textBoxIdEmpleado.Text = (from DataGridViewRow row in dataGridViewEmpleados.Rows
                                              where row.Cells[0].FormattedValue.ToString() != string.Empty
                                              select Convert.ToUInt32(row.Cells[0].FormattedValue)).Max().ToString();
                    TablaEmpleados.InsertarEmpleados(Convert.ToInt32(textBoxIdEmpleado.Text), textBoxNombre.Text, textBoxTelefono.Text, textBoxDireccion.Text);
                }
                else
                {
                    TablaEmpleados.InsertarEmpleados(Convert.ToInt32(textBoxIdEmpleado.Text), textBoxNombre.Text, textBoxTelefono.Text, textBoxDireccion.Text);
                }
            }
            else
            {
                MessageBox.Show("¡No puede Agregar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewEmpleados.DataSource = TablaEmpleados.Fill();
        }

        private void dataGridViewEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.RowCount > 0)
            {
                idEmpleado = dataGridViewEmpleados.CurrentRow.Cells[0].Value.ToString();
                Nombre = dataGridViewEmpleados.CurrentRow.Cells[1].Value.ToString();
                Telefono = dataGridViewEmpleados.CurrentRow.Cells[2].Value.ToString();
                Direccion = dataGridViewEmpleados.CurrentRow.Cells[3].Value.ToString();
                textBoxIdEmpleado.Text = idEmpleado;
                textBoxNombre.Text = Nombre;
                textBoxTelefono.Text = Telefono;
                textBoxDireccion.Text = Direccion;
            }
            else
            {

            }
        }
    }
}
