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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewProductos.DataSource = TablaProducto.Fill();
            }
        }

        //Linea de comando para sql
        SqlCommand cmd = new SqlCommand();

        private void textBoxEntradaProductos_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer.Open();
            cmd.CommandText = "SELECT * FROM dbo.Producto_Tienda WHERE idProducto LIKE '%" + textBoxEntradaProductos.Text + "%' OR NombreProducto LIKE '%" + textBoxEntradaProductos.Text + "%' " +
                    "OR CostoVenta LIKE '%" + textBoxEntradaProductos.Text + "%' OR Existencias LIKE '%" + textBoxEntradaProductos.Text + "%'";
            cmd.Connection = ConexionSQLServer.con;
            SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
            DataTable dtBusqueda = new DataTable();
            daBusqueda.Fill(dtBusqueda);
            dataGridViewProductos.DataSource = dtBusqueda;
            dataGridViewProductos.Refresh();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxEntradaProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosYLetras(e, textBoxEntradaProductos);
        }

        String idProducto, NombreProducto, CostoVenta, Existencias;

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Eliminar el registro?\nLos registros eliminados no se pueden volver a recuperar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdProducto.Text != "" && textBoxNombreProducto.Text != "" && textBoxCostoVenta.Text != "" && textBoxExistencias.Text != "")
                {
                    TablaProducto.EliminarProducto(Convert.ToInt32(textBoxIdProducto.Text));
                }
                else
                {
                    MessageBox.Show("¡No puede Eliminar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewProductos.DataSource = TablaProducto.Fill();
            }
        }

        private void textBoxIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxCostoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void textBoxExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void dataGridViewProductos_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.RowCount > 0)
            {
                idProducto = dataGridViewProductos.CurrentRow.Cells[0].Value.ToString();
                NombreProducto = dataGridViewProductos.CurrentRow.Cells[1].Value.ToString();
                CostoVenta = dataGridViewProductos.CurrentRow.Cells[2].Value.ToString();
                Existencias = dataGridViewProductos.CurrentRow.Cells[3].Value.ToString();
                textBoxIdProducto.Text = idProducto;
                textBoxNombreProducto.Text = NombreProducto;
                textBoxCostoVenta.Text = CostoVenta;
                textBoxExistencias.Text = Existencias;
            }
            else
            {

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Modificar el registro?\nLos registros Modificados no se pueden volver a recuperar", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdProducto.Text != "" && textBoxNombreProducto.Text != "" && textBoxCostoVenta.Text != "" && textBoxExistencias.Text != "")
                {
                    TablaProducto.ActualizarProducto(Convert.ToInt32(textBoxIdProducto.Text), textBoxNombreProducto.Text, float.Parse(textBoxCostoVenta.Text), Convert.ToInt32(textBoxExistencias.Text));
                }
                else
                {
                    MessageBox.Show("¡No puede Modificar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewProductos.DataSource = TablaProducto.Fill();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(textBoxIdProducto.Text != "" && textBoxNombreProducto.Text != "" && textBoxCostoVenta.Text != "" && textBoxExistencias.Text != "")
            {
                //Busca el ID mas grande y añade un 1 a el valor para no interferir con el ID de otra tupla.
                textBoxIdProducto.Text = (from DataGridViewRow row in dataGridViewProductos.Rows
                                          where row.Cells[0].FormattedValue.ToString() != string.Empty
                                          select Convert.ToUInt32(row.Cells[0].FormattedValue)).Max().ToString();
                string idProductomasuno;
                idProductomasuno = Convert.ToString(Convert.ToInt32(textBoxIdProducto.Text + 1));
                //Ese valor remplaza al valor del textbox y empieza a insertar el producto.
                textBoxIdProducto.Text = idProductomasuno;
                TablaProducto.InsertarProducto(Convert.ToInt32(textBoxIdProducto.Text), textBoxNombreProducto.Text, float.Parse(textBoxCostoVenta.Text), Convert.ToInt32(textBoxExistencias.Text));
            }
            else
            {
                MessageBox.Show("¡No puede Agregar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewProductos.DataSource = TablaProducto.Fill();
            }
        }

        private void dataGridViewProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProductos.RowCount > 0)
            {
                idProducto = dataGridViewProductos.CurrentRow.Cells[0].Value.ToString();
                NombreProducto = dataGridViewProductos.CurrentRow.Cells[1].Value.ToString();
                CostoVenta = dataGridViewProductos.CurrentRow.Cells[2].Value.ToString();
                Existencias = dataGridViewProductos.CurrentRow.Cells[3].Value.ToString();
                textBoxIdProducto.Text = idProducto;
                textBoxNombreProducto.Text = NombreProducto;
                textBoxCostoVenta.Text = CostoVenta;
                textBoxExistencias.Text = Existencias;
            }
            else
            {

            }
        }
    }
}
