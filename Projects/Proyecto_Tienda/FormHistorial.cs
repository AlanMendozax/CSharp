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
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewHistorial.DataSource = TablaRegistro.Fill();
            }
        }

        //Linea de comando para sql
        SqlCommand cmd = new SqlCommand();

        private void textBoxEntradaHistorial_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer.Open();
            cmd.CommandText = "SELECT * FROM dbo.Registro_Venta WHERE idVenta LIKE '%" + textBoxEntradaHistorial.Text + "%' " + "OR idEmpleado LIKE '%" + textBoxEntradaHistorial.Text + "%' " +
                    "OR idProducto LIKE '%" + textBoxEntradaHistorial.Text + "%' OR Cantidad LIKE '%" + textBoxEntradaHistorial.Text + "%' " + "OR Nombre_Producto LIKE '%" + textBoxEntradaHistorial.Text + "%' " +
                    "OR Fecha LIKE '%" + textBoxEntradaHistorial.Text + "%' OR Costo_del_producto LIKE '%" + textBoxEntradaHistorial.Text + "%'";
            cmd.Connection = ConexionSQLServer.con;
            SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
            DataTable dtBusqueda = new DataTable();
            daBusqueda.Fill(dtBusqueda);
            dataGridViewHistorial.DataSource = dtBusqueda;
            dataGridViewHistorial.Refresh();
        }

        String idVenta, idEmpleado, idProducto, Cantidad, Nombre_Producto, Fecha, CostoVenta;

        private void textBoxIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxNombre_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxCosto_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void buttonActualFecha_Click(object sender, EventArgs e)
        {
            dateTimePickerFecha.Text = DateTime.Now.ToString();
        }

        private void dataGridViewHistorial_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistorial.RowCount > 0)
            {
                idVenta = dataGridViewHistorial.CurrentRow.Cells[0].Value.ToString();
                idEmpleado = dataGridViewHistorial.CurrentRow.Cells[1].Value.ToString();
                idProducto = dataGridViewHistorial.CurrentRow.Cells[2].Value.ToString();
                Cantidad = dataGridViewHistorial.CurrentRow.Cells[3].Value.ToString();
                Nombre_Producto = dataGridViewHistorial.CurrentRow.Cells[4].Value.ToString();
                Fecha = dataGridViewHistorial.CurrentRow.Cells[5].Value.ToString();
                CostoVenta = dataGridViewHistorial.CurrentRow.Cells[6].Value.ToString();
                textBoxIdVenta.Text = idVenta;
                textBoxIdEmpleado.Text = idEmpleado;
                textBoxIdProducto.Text = idProducto;
                textBoxCantidad.Text = Cantidad;
                textBoxNombre_Producto.Text = Nombre_Producto;
                dateTimePickerFecha.Text = Fecha;
                textBoxCosto_Producto.Text = CostoVenta;
            }
            else
            {

            }
        }

        private void FormHistorial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBoxIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxIdVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Eliminar el registro?\nLos registros eliminados no se pueden volver a recuperar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdVenta.Text != "" && textBoxIdEmpleado.Text != "" && textBoxIdProducto.Text != "" && textBoxCantidad.Text != "" && textBoxNombre_Producto.Text != "" && textBoxCosto_Producto.Text != "")
                {
                    TablaRegistro.EliminarRegistro(Convert.ToInt32(textBoxIdVenta.Text));
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
                dataGridViewHistorial.DataSource = TablaRegistro.Fill();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Modificar el registro?\nLos registros Modificados no se pueden volver a recuperar", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdVenta.Text != "" && textBoxIdEmpleado.Text != "" && textBoxIdProducto.Text != "" && textBoxCantidad.Text != "" && textBoxNombre_Producto.Text != "" && textBoxCosto_Producto.Text != "")
                {
                    DateTime FechaRegistro = new DateTime();
                    FechaRegistro = dateTimePickerFecha.Value.Date;
                    TablaRegistro.ActualizarRegistro(Convert.ToInt32(idVenta), Convert.ToInt32(idEmpleado), Convert.ToInt32(idProducto), Convert.ToInt32(Cantidad), Nombre_Producto, FechaRegistro, float.Parse(CostoVenta));
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
                dataGridViewHistorial.DataSource = TablaRegistro.Fill();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxIdVenta.Text != "" && textBoxIdEmpleado.Text != "" && textBoxIdProducto.Text != "" && textBoxCantidad.Text != "" && textBoxNombre_Producto.Text != "" && textBoxCosto_Producto.Text != "")
            {
                DateTime FechaRegistro = new DateTime();
                FechaRegistro = dateTimePickerFecha.Value.Date;
                if (dataGridViewHistorial.RowCount > 0)
                {
                    textBoxIdVenta.Text = (from DataGridViewRow row in dataGridViewHistorial.Rows
                                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                                           select Convert.ToUInt32(row.Cells[0].FormattedValue)).Max().ToString();
                    TablaRegistro.InsertarRegistro(Convert.ToInt32(idVenta), Convert.ToInt32(idEmpleado), Convert.ToInt32(idProducto), Convert.ToInt32(Cantidad), Nombre_Producto, FechaRegistro, float.Parse(CostoVenta));
                }
                else
                {
                    TablaRegistro.InsertarRegistro(Convert.ToInt32(idVenta), Convert.ToInt32(idEmpleado), Convert.ToInt32(idProducto), Convert.ToInt32(Cantidad), Nombre_Producto, FechaRegistro, float.Parse(CostoVenta));
                }
            }
            else
            {
                MessageBox.Show("¡No puede Agregar campos vacios!\nPuede remplazar el campo vacio por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewHistorial.DataSource = TablaRegistro.Fill();
            }
        }

        private void dataGridViewHistorial_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewHistorial.RowCount > 0)
            {
                idVenta = dataGridViewHistorial.CurrentRow.Cells[0].Value.ToString();
                idEmpleado = dataGridViewHistorial.CurrentRow.Cells[1].Value.ToString();
                idProducto = dataGridViewHistorial.CurrentRow.Cells[2].Value.ToString();
                Cantidad = dataGridViewHistorial.CurrentRow.Cells[3].Value.ToString();
                Nombre_Producto = dataGridViewHistorial.CurrentRow.Cells[4].Value.ToString();
                Fecha = dataGridViewHistorial.CurrentRow.Cells[5].Value.ToString();
                CostoVenta = dataGridViewHistorial.CurrentRow.Cells[6].Value.ToString();
                textBoxIdVenta.Text = idVenta;
                textBoxIdEmpleado.Text = idEmpleado;
                textBoxIdProducto.Text = idProducto;
                textBoxCantidad.Text = Cantidad;
                textBoxNombre_Producto.Text = Nombre_Producto;
                dateTimePickerFecha.Text = Fecha;
                textBoxCosto_Producto.Text = CostoVenta;
            }
            else
            {

            }
        }
    }
}
