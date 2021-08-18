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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables utilizadas.
        String TablaSeleccionada;
        DataTable Venta = new DataTable();
        double SumaVenta = 0;
        
        //Métdodos usados.
        void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                //Declaramos las variables a utilizar con las librerias de excel.
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo.
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        //Componentes del Programa.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Llenando el ComboBoxEmpleados para obtener ID
            DataTable Empleados = new DataTable();
            Empleados = TablaEmpleados.Fill();
            foreach (DataRow dr in Empleados.Rows)
            {
                int Valores = dr.Field<int>("idEmpleados");
                comboBoxEmpleados.Items.Add(Valores);
            }
            comboBoxEmpleados.SelectedIndex = 0;
            //Creando la tabla para vender
            DataTable Tabla_de_venta = new DataTable();
            Tabla_de_venta.Columns.Add("idProducto", typeof(int));
            Tabla_de_venta.Columns.Add("NombreProducto", typeof(string));
            Tabla_de_venta.Columns.Add("Costo", typeof(float));
            Tabla_de_venta.Columns.Add("Cantidad", typeof(int));
            dataGridViewVenta.DataSource = Tabla_de_venta;
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewTablas.DataSource = TablaProducto.Fill();
                TablaSeleccionada = "productos";
                labelTablaActual.Text = "Tabla Actual: Productos";
            }
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            //Creamos una tabla con el historial de venta para buscar ID's.
            DataTable Registros = new DataTable();
            //Se llena la nueva tabla con los datos de la BD.
            Registros = TablaRegistro.Fill();
            //Obtener el ID mas grande y sumar uno para obtener un nuevo ID.
            int MaxIDRegsitro = int.MinValue, NuevoIDRegistro = 0;
            foreach (DataRow dr in Registros.Rows)
            {
                int Valores = dr.Field<int>("idVenta");
                MaxIDRegsitro = Math.Max(MaxIDRegsitro, Valores);
            }
            //Obtenemos un nuevo ID para el registro
            NuevoIDRegistro = MaxIDRegsitro + 1;
            //Mensaje de la venta realizada
            MessageBox.Show("El total de la venta es de: "+labelSumaVenta.Text+"\nIVA:16%\nCosto sin IVA:"+(SumaVenta - (SumaVenta * .16)),"Venta realizada",MessageBoxButtons.OK);
            //Reiniciamos valores para volver a calcular.
            SumaVenta = 0;
            labelSumaVenta.Text = "Nada";
            //Creamos una variable que indica cuando se actualizo la tupla del producto.
            String Bandera = "NoRealizado";
            //Buscamos que coincidan el idProducto en ambos dataGridView.
            foreach (DataGridViewRow rowVentas in dataGridViewVenta.Rows)
            {
                Bandera = "NoRealizado";
                foreach (DataGridViewRow rowTablas in dataGridViewTablas.Rows)
                {
                    if (Convert.ToInt32(rowVentas.Cells[0].Value) == Convert.ToInt32(rowTablas.Cells[0].Value) && Bandera == "NoRealizado")
                    {
                        //En este punto los ID del producto coinciden en ambas tablas.
                        int ExistenciasActualizadas = 0, ExistenciasProducto = 0, CantidadVenta = 0;
                        ExistenciasProducto = Convert.ToInt32(rowTablas.Cells[3].Value);
                        CantidadVenta = Convert.ToInt32(rowVentas.Cells[3].Value);
                        //Restamos la cantidad de productos en la tabla de ventas a la tabla del inventario. Se obtiene la nueva cantidad del producto en almacén.
                        ExistenciasActualizadas = ExistenciasProducto - CantidadVenta;
                        //Actualizar valor en la tabla de productos.
                        TablaProducto.ActualizarProducto(Convert.ToInt32(rowVentas.Cells[0].Value), Convert.ToString(rowVentas.Cells[1].Value),
                            float.Parse(Convert.ToString(rowVentas.Cells[2].Value)), ExistenciasActualizadas);
                        TablaRegistro.InsertarRegistro(NuevoIDRegistro,Convert.ToInt32(comboBoxEmpleados.Text), Convert.ToInt32(rowVentas.Cells[0].Value), Convert.ToInt32(rowVentas.Cells[3].Value), 
                            Convert.ToString(rowVentas.Cells[1].Value), DateTime.Now, float.Parse(Convert.ToString(rowVentas.Cells[2].Value)));
                        //Se actualizo la tupla en la BD.
                        Bandera = "Realizado";
                    }
                }
            }
            //Se actualiza el dataGridView del inventario con los cambios.
            dataGridViewTablas.DataSource = TablaProducto.Fill();
            DataTable Tabla_de_venta = new DataTable();
            Tabla_de_venta.Columns.Add("idProducto", typeof(int));
            Tabla_de_venta.Columns.Add("NombreProducto", typeof(string));
            Tabla_de_venta.Columns.Add("Costo", typeof(float));
            Tabla_de_venta.Columns.Add("Cantidad", typeof(int));
            dataGridViewVenta.DataSource = Tabla_de_venta;
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewTablas.DataSource = TablaProducto.Fill();
                TablaSeleccionada = "productos";
                labelTablaActual.Text = "Tabla Actual: Productos";
            }
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewTablas.DataSource = TablaProducto.Fill();
            }
            TablaSeleccionada = "productos";
            labelTablaActual.Text = "Tabla Actual: Productos";
        }

        private void buttonApartados_Click(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewTablas.DataSource = TablaApartados.Fill();
            }
            TablaSeleccionada = "apartados";
            labelTablaActual.Text = "Tabla Actual: Apartados";
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                dataGridViewTablas.DataSource = TablaEmpleados.Fill();
            }
            TablaSeleccionada = "empleadostienda";
            labelTablaActual.Text = "Tabla Actual: Empleados";
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConexionSQLServer.Open() != null)
            {
                //dataGridViewTablas.DataSource = TablaRegistro.Fill();
                ConexionSQLServer.Open();
                cmd.CommandText = "SELECT * FROM dbo.Registro_Venta WHERE Fecha = '"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
                cmd.Connection = ConexionSQLServer.con;
                SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
                DataTable dtBusqueda = new DataTable();
                daBusqueda.Fill(dtBusqueda);
                dataGridViewTablas.DataSource = dtBusqueda;
                dataGridViewTablas.Refresh();
            }
            TablaSeleccionada = "registro_venta";
            labelTablaActual.Text = "Tabla Actual: Registro de Ventas";
            //Calcular el total de la venta en la tabla de venta
            if (dataGridViewTablas.RowCount > 0)
            {
                SumaVenta = 0;
                foreach (DataGridViewRow row in dataGridViewTablas.Rows)
                {
                    SumaVenta += (Convert.ToDouble(row.Cells[dataGridViewTablas.Columns[3].Index].Value) * Convert.ToDouble(row.Cells[dataGridViewTablas.Columns[6].Index].Value));
                }
                MessageBox.Show("Hoy "+DateTime.Now.ToLongDateString()+" A registrado un total de "+SumaVenta+" pesos","TOTAL DE LA VENTA DE HOY",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Cerrando...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ConexionSQLServer.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBoxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridViewTablas_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros.NumerosYLetras(e,textBoxEntrada);
        }

        SqlCommand cmd = new SqlCommand();

        private void textBoxEntrada_TextChanged(object sender, EventArgs e)
        {
            String dboSeleccionado = "";
            ConexionSQLServer.Open();
            //Funcion de busqueda en el textbox
            if (TablaSeleccionada == "apartados")
            {
                dboSeleccionado = "dbo.Apartados_Tienda";
                cmd.CommandText = "SELECT * FROM " + dboSeleccionado + " WHERE idApartados LIKE '%" + textBoxEntrada.Text + "%' OR idProducto LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR NombreCliente LIKE '%" + textBoxEntrada.Text + "%' OR Telefono LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR Abono_1 LIKE '%" + textBoxEntrada.Text + "%' OR Abono_2 LIKE '%" + textBoxEntrada.Text + "%' OR Abono_3 LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR Importe LIKE '%" + textBoxEntrada.Text + "%' OR Resta LIKE '%" + textBoxEntrada.Text + "%' OR Total_a_pagar LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR Comentario LIKE '%" + textBoxEntrada.Text + "%'";
            }
            if (TablaSeleccionada == "empleadostienda")
            {
                dboSeleccionado = "dbo.Empleados_Tienda";
                cmd.CommandText = "SELECT * FROM " + dboSeleccionado + " WHERE idEmpleados LIKE '%" + textBoxEntrada.Text + "%' " + "OR Nombre LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR Telefono LIKE '%" + textBoxEntrada.Text + "%' OR Direccion LIKE '%" + textBoxEntrada.Text + "%'";
            }
            if (TablaSeleccionada == "productos")
            {
                dboSeleccionado = "dbo.Producto_Tienda";
                cmd.CommandText = "SELECT * FROM " + dboSeleccionado + " WHERE idProducto LIKE '%" + textBoxEntrada.Text + "%' OR NombreProducto LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR CostoVenta LIKE '%" + textBoxEntrada.Text + "%' OR Existencias LIKE '%" + textBoxEntrada.Text + "%'";
            }
            if (TablaSeleccionada == "registro_venta")
            {
                dboSeleccionado = "dbo.Registro_Venta";
                cmd.CommandText = "SELECT * FROM " + dboSeleccionado + " WHERE idVenta LIKE '%" + textBoxEntrada.Text + "%' " + "OR idEmpleado LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR idProducto LIKE '%" + textBoxEntrada.Text + "%' OR Cantidad LIKE '%" + textBoxEntrada.Text + "%' " + "OR Nombre_Producto LIKE '%" + textBoxEntrada.Text + "%' " +
                    "OR Fecha LIKE '%" + textBoxEntrada.Text + "%' OR Costo_del_producto LIKE '%" + textBoxEntrada.Text + "%'";
            }
            if (dboSeleccionado == "")
            {
                MessageBox.Show("Se necesita seleccionar una tabla", "No hay tabla seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cmd.Connection = ConexionSQLServer.con;
            SqlDataAdapter daBusqueda = new SqlDataAdapter(cmd);
            DataTable dtBusqueda = new DataTable();
            daBusqueda.Fill(dtBusqueda);
            dataGridViewTablas.DataSource = dtBusqueda;
            dataGridViewTablas.Refresh();
        }

        private void dataGridViewTablas_DoubleClick(object sender, EventArgs e)
        {
            //Añadir tuplas a la tabla de venta
            if (TablaSeleccionada != "productos")
            {
                MessageBox.Show("Asegurese que de seleccionar la tabla de PRODUCTOS", "Tabla incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Se ponen por separado para identificar las posiciones de las columnas.
                String idProducto, NombreProducto, CostoVenta, Cantidad;
                //Obteniendo datos de la tabla del inventario.
                idProducto = dataGridViewTablas.CurrentRow.Cells[0].Value.ToString();
                NombreProducto = dataGridViewTablas.CurrentRow.Cells[1].Value.ToString();
                CostoVenta = dataGridViewTablas.CurrentRow.Cells[2].Value.ToString();
                Cantidad = dataGridViewTablas.CurrentRow.Cells[3].Value.ToString();
                //Guardando datos en la tabla de la venta.

                //Debido a que los datos estan enlazados debemos hacer una nueva tupla mediante DataTable
                DataTable dt2 = new DataTable();
                dt2 = dataGridViewVenta.DataSource as DataTable;
                DataRow datarow;
                datarow = dt2.NewRow();

                //Encontrando Tuplas con datos ya cargados (Solo cambiara la cantidad)
                bool Found = false;
                if (dataGridViewVenta.Rows.Count > 0)
                {
                    //Buscando producto en la tabla de la venta
                    foreach (DataGridViewRow rowVenta in dataGridViewVenta.Rows)
                    {
                        if (Convert.ToString(rowVenta.Cells[0].Value) == idProducto)
                        {
                            if (Convert.ToInt32(rowVenta.Cells[3].Value) < Convert.ToInt32(Cantidad))
                            {
                                rowVenta.Cells[3].Value = Convert.ToString(1 + Convert.ToInt32(rowVenta.Cells[3].Value));
                                Found = true;
                            }
                            else
                            {
                                MessageBox.Show("NO HAY PRODUCTOS SUFICIENTES EN ALMACÉN\nLa venta no se puede ser realizada por falta de: " + NombreProducto + " en almacén", "FALTA PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Found = true;
                            }
                        }
                    }
                    //Si no se encuentra el producto ya en la tabla de ventas, se crea una nueva tupla.
                    if (!Found && Convert.ToInt32(Cantidad) > 0)
                    {
                        datarow["idProducto"] = Convert.ToInt32(idProducto);
                        datarow["NombreProducto"] = NombreProducto;
                        datarow["Costo"] = float.Parse(CostoVenta);
                        datarow["Cantidad"] = 1;
                        dt2.Rows.Add(datarow);
                    }
                    if (!Found && Convert.ToInt32(Cantidad) < 0)
                    {
                        MessageBox.Show("NO HAY PRODUCTOS SUFICIENTES EN ALMACÉN\nLa venta no se puede ser realizada por falta de: " + NombreProducto + " en almacén", "FALTA PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Found = true;
                    }
                }
                //Si no hay tuplas en la tabla de ventas, se agrega una nueva.
                if (dataGridViewVenta.Rows.Count <= 0 && Convert.ToInt32(Cantidad) > 0)
                {
                    datarow["idProducto"] = Convert.ToInt32(idProducto);
                    datarow["NombreProducto"] = NombreProducto;
                    datarow["Costo"] = float.Parse(CostoVenta);
                    datarow["Cantidad"] = 1;
                    dt2.Rows.Add(datarow);
                }
                if (dataGridViewVenta.Rows.Count <= 0 && Convert.ToInt32(Cantidad) < 0)
                {
                    MessageBox.Show("NO HAY PRODUCTOS SUFICIENTES EN ALMACÉN\nLa venta no se puede ser realizada por falta de: " + NombreProducto + " en almacén", "FALTA PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Found = true;
                }
                //Calcular el total de la venta en la tabla de venta
                if (dataGridViewVenta.RowCount > 0)
                {
                    SumaVenta = 0;
                    foreach (DataGridViewRow row in dataGridViewVenta.Rows)
                    {
                        SumaVenta += (Convert.ToDouble(row.Cells[dataGridViewVenta.Columns[2].Index].Value) * Convert.ToDouble(row.Cells[dataGridViewVenta.Columns[3].Index].Value));
                        labelSumaVenta.Text = Convert.ToString(SumaVenta);
                    }
                }
                else
                {

                }
            }
        }

        private void dataGridViewVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dataGridViewTablas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridViewVenta.Rows[e.RowIndex].IsNewRow)
            {
                dataGridViewVenta.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void actualTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dataGridViewTablas);
        }

        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewTablas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridViewVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto VerInventario = new FormProducto();
            if (VerInventario.ShowDialog() == DialogResult.Cancel)
            {
                if (ConexionSQLServer.Open() != null)
                {
                    dataGridViewTablas.DataSource = TablaProducto.Fill();
                    TablaSeleccionada = "productos";
                    labelTablaActual.Text = "Tabla Actual: Productos";
                }
            }
            else
            {

            }
        }

        private void verApartadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApartados VerApartados = new FormApartados();
            if (VerApartados.ShowDialog() == DialogResult.Cancel)
            {
                if (ConexionSQLServer.Open() != null)
                {
                    dataGridViewTablas.DataSource = TablaProducto.Fill();
                    TablaSeleccionada = "productos";
                    labelTablaActual.Text = "Tabla Actual: Productos";
                }
            }
            else
            {

            }
        }

        private void administrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados VerEmpleados = new FormEmpleados();
            if (VerEmpleados.ShowDialog() == DialogResult.Cancel)
            {
                if (ConexionSQLServer.Open() != null)
                {
                    dataGridViewTablas.DataSource = TablaProducto.Fill();
                    TablaSeleccionada = "productos";
                    labelTablaActual.Text = "Tabla Actual: Productos";
                }
            }
            else
            {

            }
        }

        private void historialDeVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHistorial VerHistorial = new FormHistorial();
            if (VerHistorial.ShowDialog() == DialogResult.Cancel)
            {
                if (ConexionSQLServer.Open() != null)
                {
                    dataGridViewTablas.DataSource = TablaProducto.Fill();
                    TablaSeleccionada = "productos";
                    labelTablaActual.Text = "Tabla Actual: Productos";
                }
            }
            else
            {

            }
        }
    }
}