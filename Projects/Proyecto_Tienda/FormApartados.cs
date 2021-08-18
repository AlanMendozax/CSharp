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
    public partial class FormApartados : Form
    {
        public FormApartados()
        {
            InitializeComponent();
        }

        private void FormApartados_Load(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewApartados.DataSource = TablaApartados.Fill();
            }
        }

        private void textBoxResta_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //Variables a utilizar
        float fAbono_1, fAbono_2, fAbono_3, fResta, fImporte, fTotal;

        //Linea de comando para sql
        SqlCommand cmd = new SqlCommand();

        private void textBoxEntradaApartados_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer.Open();
            cmd.CommandText = "SELECT * FROM dbo.Apartados_Tienda WHERE idApartados LIKE '%" + textBoxEntradaApartados.Text + "%' OR idProducto LIKE '%" + textBoxEntradaApartados.Text + "%' " +
                    "OR NombreCliente LIKE '%" + textBoxEntradaApartados.Text + "%' OR Telefono LIKE '%" + textBoxEntradaApartados.Text + "%' " +
                    "OR Abono_1 LIKE '%" + textBoxEntradaApartados.Text + "%' OR Abono_2 LIKE '%" + textBoxEntradaApartados.Text + "%' OR Abono_3 LIKE '%" + textBoxEntradaApartados.Text + "%' " +
                    "OR Importe LIKE '%" + textBoxEntradaApartados.Text + "%' OR Resta LIKE '%" + textBoxEntradaApartados.Text + "%' OR Total_a_pagar LIKE '%" + textBoxEntradaApartados.Text + "%' " +
                    "OR Comentario LIKE '%" + textBoxEntradaApartados.Text + "%'";
            cmd.Connection = ConexionSQLServer.con;
            SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
            DataTable dtBusqueda = new DataTable();
            daBusqueda.Fill(dtBusqueda);
            dataGridViewApartados.DataSource = dtBusqueda;
            dataGridViewApartados.Refresh();
        }

        String idApartado, idProducto, NombreCliente, Telefono, Abono_1, Abono_2, Abono_3, Importe, Resta, Total_a_pagar, Comentario;

        private void textBoxAbono_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void textBoxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void textBoxResta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Deshablitado
        }

        private void textBoxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Deshabilitado
        }

        private void textBoxComentario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridViewApartados_Click(object sender, EventArgs e)
        {
            if (dataGridViewApartados.RowCount > 0)
            {
                idApartado = dataGridViewApartados.CurrentRow.Cells[0].Value.ToString();
                idProducto = dataGridViewApartados.CurrentRow.Cells[1].Value.ToString();
                NombreCliente = dataGridViewApartados.CurrentRow.Cells[2].Value.ToString();
                Telefono = dataGridViewApartados.CurrentRow.Cells[3].Value.ToString();
                Abono_1 = dataGridViewApartados.CurrentRow.Cells[4].Value.ToString();
                Abono_2 = dataGridViewApartados.CurrentRow.Cells[5].Value.ToString();
                Abono_3 = dataGridViewApartados.CurrentRow.Cells[6].Value.ToString();
                Importe = dataGridViewApartados.CurrentRow.Cells[7].Value.ToString();
                Resta = dataGridViewApartados.CurrentRow.Cells[8].Value.ToString();
                Total_a_pagar = dataGridViewApartados.CurrentRow.Cells[9].Value.ToString();
                Comentario = dataGridViewApartados.CurrentRow.Cells[10].Value.ToString();
                textBoxIdApartado.Text = idApartado;
                textBoxIdProducto.Text = idProducto;
                textBoxNombre_Cliente.Text = NombreCliente;
                textBoxTelefono.Text = Telefono;
                textBoxAbono_1.Text = Abono_1;
                textBoxAbono_2.Text = Abono_2;
                textBoxAbono_3.Text = Abono_3;
                textBoxImporte.Text = Importe;
                textBoxResta.Text = Resta;
                textBoxTotal.Text = Total_a_pagar;
                textBoxComentario.Text = Comentario;
            }
            else
            {

            }
        }

        private void textBoxAbono_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void textBoxAbono_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosDecimales(e);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxNombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void textBoxIdApartado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.SoloNumeros(e);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Eliminar el registro?\nLos registros eliminados no se pueden volver a recuperar", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdApartado.Text != "" && textBoxIdProducto.Text != "" && textBoxNombre_Cliente.Text != "" && textBoxTelefono.Text != "" && textBoxAbono_1.Text != "" && textBoxAbono_2.Text != "" && textBoxAbono_3.Text != "" && textBoxImporte.Text != "")
                {
                    TablaApartados.EliminarApartados(Convert.ToInt32(textBoxIdApartado.Text));
                }
                else
                {
                    MessageBox.Show("¡No puede Eliminar campos vacios!\nPuede remplazar el campo vacio por 0\nLos comentarios pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            dataGridViewApartados.DataSource = TablaApartados.Fill();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea Modificar el registro?\nLos registros eliminados no se pueden volver a recuperar", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (textBoxIdApartado.Text != "" && textBoxIdProducto.Text != "" && textBoxNombre_Cliente.Text != "" && textBoxTelefono.Text != "" && textBoxAbono_1.Text != "" && textBoxAbono_2.Text != "" && textBoxAbono_3.Text != "" && textBoxImporte.Text != "")
                {
                    OperacionImporteTotal();
                    TablaApartados.ActualizarApartados(Convert.ToInt32(textBoxIdApartado.Text), Convert.ToInt32(textBoxIdProducto), textBoxNombre_Cliente.Text, textBoxTelefono.Text, 
                        float.Parse(textBoxAbono_1.Text), float.Parse(textBoxAbono_2.Text), float.Parse(textBoxAbono_3.Text), fImporte, fResta, fTotal, textBoxComentario.Text);
                }
                else
                {
                    MessageBox.Show("¡No puede Modificar campos vacios!\nPuede remplazar el campo vacio por 0\nLos comentarios pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
            dataGridViewApartados.DataSource = TablaApartados.Fill();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxIdApartado.Text != "" && textBoxIdProducto.Text != "" && textBoxNombre_Cliente.Text != "" && textBoxTelefono.Text != "" && textBoxAbono_1.Text != "" && textBoxAbono_2.Text != "" && textBoxAbono_3.Text != "" && textBoxImporte.Text != "")
            {
                OperacionImporteTotal();
                if (dataGridViewApartados.RowCount > 0)
                {
                    textBoxIdApartado.Text = (from DataGridViewRow row in dataGridViewApartados.Rows
                                              where row.Cells[0].FormattedValue.ToString() != string.Empty
                                              select Convert.ToUInt32(row.Cells[0].FormattedValue)).Max().ToString();
                    TablaApartados.InsertarApartados(Convert.ToInt32(textBoxIdApartado.Text), Convert.ToInt32(textBoxIdProducto), textBoxNombre_Cliente.Text, textBoxTelefono.Text,
                        float.Parse(textBoxAbono_1.Text), float.Parse(textBoxAbono_2.Text), float.Parse(textBoxAbono_3.Text), fImporte, fResta, fTotal, textBoxComentario.Text);

                }
                else
                {
                    TablaApartados.InsertarApartados(Convert.ToInt32(textBoxIdApartado.Text), Convert.ToInt32(textBoxIdProducto.Text), textBoxNombre_Cliente.Text, textBoxTelefono.Text,
                        float.Parse(textBoxAbono_1.Text), float.Parse(textBoxAbono_2.Text), float.Parse(textBoxAbono_3.Text), fImporte, fResta, fTotal, textBoxComentario.Text);
                }
            }
            else
            {
                MessageBox.Show("¡No puede Agregar campos vacios!\nPuede remplazar el campo vacio por 0\nLos comentarios pueden estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewApartados.DataSource = TablaApartados.Fill();
        }

        private void dataGridViewApartados_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewApartados.RowCount > 0)
            {
                idApartado = dataGridViewApartados.CurrentRow.Cells[0].Value.ToString();
                idProducto = dataGridViewApartados.CurrentRow.Cells[1].Value.ToString();
                NombreCliente = dataGridViewApartados.CurrentRow.Cells[2].Value.ToString();
                Telefono = dataGridViewApartados.CurrentRow.Cells[3].Value.ToString();
                fAbono_1 = float.Parse(dataGridViewApartados.CurrentRow.Cells[4].Value.ToString());
                fAbono_2 = float.Parse(dataGridViewApartados.CurrentRow.Cells[5].Value.ToString());
                fAbono_3 = float.Parse(dataGridViewApartados.CurrentRow.Cells[6].Value.ToString());
                Importe = dataGridViewApartados.CurrentRow.Cells[7].Value.ToString();
                fResta = float.Parse(dataGridViewApartados.CurrentRow.Cells[8].Value.ToString());
                fTotal = float.Parse(dataGridViewApartados.CurrentRow.Cells[9].Value.ToString());
                Comentario = dataGridViewApartados.CurrentRow.Cells[10].Value.ToString();
                textBoxIdApartado.Text = idApartado;
                textBoxIdProducto.Text = idProducto;
                textBoxNombre_Cliente.Text = NombreCliente;
                textBoxTelefono.Text = Telefono;
                textBoxAbono_1.Text = Convert.ToString(fAbono_1);
                textBoxAbono_2.Text = Convert.ToString(fAbono_2);
                textBoxAbono_3.Text = Convert.ToString(fAbono_3);
                textBoxImporte.Text = Importe;
                OperacionImporteTotal();
                textBoxComentario.Text = Comentario;
            }
            else
            {

            }
        }
        void OperacionImporteTotal()
        {
            fAbono_1 = float.Parse(textBoxAbono_1.Text);
            fAbono_2 = float.Parse(textBoxAbono_2.Text);
            fAbono_3 = float.Parse(textBoxAbono_3.Text);
            fImporte = float.Parse(textBoxImporte.Text);
            fResta = fAbono_1 + fAbono_2 + fAbono_3;
            fTotal = fImporte - fResta;
            textBoxResta.Text = Convert.ToString(fResta);
            textBoxTotal.Text = Convert.ToString(fTotal);
        }
    }
}
