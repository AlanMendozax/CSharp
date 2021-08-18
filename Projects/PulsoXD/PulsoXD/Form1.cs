//Librerias
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PulsoXD
{
    public partial class Form1 : Form
    {
        //Parametros y conexion a la BD
        string connectionsString = @"Server=localhost;Database=signosv;Uid=root;Pwd=admin;";
        int varid = 0;
        string rfid = "";
        string[] oxi1 = new string[] { "97%", "97%", "96%","97%", "97%", "96%" };
        string[] pulso1 = new string[] { "63 ppm", "71 ppm", "65 ppm", "73 ppm", "72 ppm", "75 ppm" };
        string[] temp1 = new string[] { "36.14 °C", "36.13 °C", "36.12 °C", "36.14 °C", "36.16 °C", "36.14 °C" };
        System.IO.Ports.SerialPort ArduinoPort;

        public object ImageHelper { get; private set; }

        public Form1()
        {
            InitializeComponent();
          
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM6";
            ArduinoPort.BaudRate = 9600;
            try { ArduinoPort.Open(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            GridFill();
            dataGridView1.Columns[2].HeaderText = "clave paciente";
            dataGridView1.Columns[1].HeaderText = "Nombre(s)";
            dataGridView1.Columns[2].HeaderText = "Apellido materno";
            dataGridView1.Columns[3].HeaderText = "Apellido paterno";
            combed.Text = "Seleccionar";
            combed.Items.Add("Femenino");
            combed.Items.Add("Masculino");
           timer1.Start();


            combsang.Text = "Seleccionar";
            combsang.Items.Add("O -");
            combsang.Items.Add("O +");
            combsang.Items.Add("A -");
            combsang.Items.Add("A +");
            combsang.Items.Add("B -");
            combsang.Items.Add("B +");
            combsang.Items.Add("AB -");
            combsang.Items.Add("AB +");      
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;          
        }

        private void button5_Click(object sender, EventArgs e)
        {

                bool isNullOrEmpty = (pictureBox1.Image == null);
                if (txtnom.Text == "" || txtapep.Text == "" || txtapem.Text == "" || txted.Text == "" || txtcurp.Text == "" || txtdir.Text == "" || txtnomcontacto.Text == "" || txttelcon.Text == "" || txtparcont.Text == "" || txtID.Text == "" || txtale.Text == "" || combed.SelectedIndex < 0 || combsang.SelectedIndex < 0 || isNullOrEmpty)
                {
                    MessageBox.Show("Verifique que los campos estén llenos", "Alerta");
                }
                else
                {

                    try
                    {
                        using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
                        {
                            sqlcon.Open();
                            MySqlCommand cmnd = new MySqlCommand("addoredit", sqlcon);
                            cmnd.CommandType = CommandType.StoredProcedure;

                            MemoryStream ms = new MemoryStream();
                            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] aByte = ms.ToArray();
                            cmnd.Parameters.AddWithValue("_var", varid);
                            cmnd.Parameters.AddWithValue("_clave", txtID.Text.Trim());
                            cmnd.Parameters.AddWithValue("_nombre", txtnom.Text.Trim());
                            cmnd.Parameters.AddWithValue("_apellidop", txtapep.Text.Trim());
                            cmnd.Parameters.AddWithValue("_apellidom", txtapem.Text.Trim());
                            cmnd.Parameters.AddWithValue("_edad", txted.Text.Trim());
                            cmnd.Parameters.AddWithValue("_sexo", combed.SelectedItem.ToString().Trim());
                            cmnd.Parameters.AddWithValue("_tsangre", combsang.SelectedItem.ToString().Trim());
                            cmnd.Parameters.AddWithValue("_alergias", txtale.Text.Trim());
                            cmnd.Parameters.AddWithValue("_curp", txtcurp.Text.Trim());
                            cmnd.Parameters.AddWithValue("_Direccion", txtdir.Text.Trim());
                            cmnd.Parameters.AddWithValue("_nombre_contacto", txtnomcontacto.Text.Trim());
                            cmnd.Parameters.AddWithValue("_telefono_contacto", txttelcon.Text.Trim());
                            cmnd.Parameters.AddWithValue("_parentesco_contacto", txtparcont.Text.Trim());
                            cmnd.Parameters.AddWithValue("_img", aByte);

                            cmnd.ExecuteNonQuery();
                            GridFill();
                            clear();
                            sqlcon.Close();
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }            
        }


        void clear()
        {
            varid = 0;
            txtnom.Text = txtapep.Text = txtapem.Text = txted.Text = txtcurp.Text = txtdir.Text = txtnomcontacto.Text = txttelcon.Text = txtparcont.Text = txtID.Text = txtale.Text= "";
            combed.Text = combsang.Text = "Seleccionar";
            pictureBox1.Image = null;
            button5.Text = "   Guardar";
            button6.Enabled = false;
        }

      public static Bitmap aImagen(byte[] img)
        {
            MemoryStream cadena = new MemoryStream();
            byte[] buffer = img;
            Bitmap bitmap;
            cadena = new MemoryStream(buffer);
            bitmap = new Bitmap(cadena);
            cadena.Close();
            return bitmap;
        }

        void GridFill()
        {
            
            using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
            {
                sqlcon.Open();
                MySqlDataAdapter sqldat = new MySqlDataAdapter("ViewAll", sqlcon);
                sqldat.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dttbl = new DataTable();
                sqldat.Fill(dttbl);
                dataGridView1.DataSource = dttbl;
                sqlcon.Close();
                dataGridView1.Columns[13].Visible = false;
            }
      
        }

        void GridFill2()
        {

            using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
            {
                sqlcon.Open();
                MySqlDataAdapter sqldat = new MySqlDataAdapter("selallhist", sqlcon);
                sqldat.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dttbl2 = new DataTable();
                sqldat.Fill(dttbl2);
                dataGridView2.DataSource = dttbl2;
                sqlcon.Close();          
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string par = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
                {

                    sqlcon.Open();
                    MySqlCommand cmnd = new MySqlCommand("delete", sqlcon);
                    cmnd.CommandType = CommandType.StoredProcedure;
                    cmnd.Parameters.AddWithValue("_idpat", par);
                    cmnd.ExecuteNonQuery();
                    GridFill();
                    clear();
                    sqlcon.Close();
                }
            }

             catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen |*.jpg| Archivo PNG|*.png|Todos los archivos|*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            varid = 1;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                
                    string par = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
                    {

                        sqlcon.Open();
                        MySqlCommand cmnd = new MySqlCommand("imgselect", sqlcon);
                        cmnd.CommandType = CommandType.StoredProcedure;
                        cmnd.Parameters.AddWithValue("_idpat", par);
                        cmnd.ExecuteNonQuery();
                        MySqlDataReader leer = cmnd.ExecuteReader();
                        if (leer.Read())
                        {
                            Bitmap nbitmap;
                        nbitmap = aImagen((byte[])leer["img"]);
                        pictureBox1.Image = new Bitmap(nbitmap, pictureBox1.Size);
                        pictureBox2.Image = new Bitmap(nbitmap, pictureBox2.Size);

                         }
                        sqlcon.Close();
                    }

                    txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
                txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtapep.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtapem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txted.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                combed.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                combsang.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtale.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtcurp.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtdir.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtnomcontacto.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txttelcon.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtparcont.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                //varid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value.ToString()); ;
                button5.Text = "    Actualizar";
                button6.Enabled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
            {
                sqlcon.Open();
                MySqlDataAdapter sqldat = new MySqlDataAdapter("SearchByValue", sqlcon);
                sqldat.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqldat.SelectCommand.Parameters.AddWithValue("_SearchValue", txtbusq.Text);
                DataTable dttbl = new DataTable();
                sqldat.Fill(dttbl);
                dataGridView1.DataSource = dttbl;
                sqlcon.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            label25.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label26.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label27.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label28.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label29.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label30.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label31.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label32.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label33.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label42.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label33.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label34.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label35.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            label36.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            callhist();
        }

        void callhist()
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
            {
                sqlcon.Open();
                MySqlDataAdapter sqldat = new MySqlDataAdapter("selallhist", sqlcon);
                sqldat.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqldat.SelectCommand.Parameters.AddWithValue("_idpat", label25.Text.Trim());
                DataTable dttbl2 = new DataTable();
                sqldat.Fill(dttbl2);
                dataGridView2.DataSource = dttbl2;
                sqlcon.Close();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ""|| textBox2.Text == ""|| textBox3.Text == "")
            {
                MessageBox.Show("Verifique que los campos estén llenos", "Alerta");
            }
            else
            {

                try
                {
                    using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
                    {
                        sqlcon.Open();
                        MySqlCommand cmnd = new MySqlCommand("histinsert", sqlcon);
                        cmnd.CommandType = CommandType.StoredProcedure;

                        cmnd.Parameters.AddWithValue("_idpacient", label25.Text.Trim());
                        cmnd.Parameters.AddWithValue("_mot", textBox1.Text.Trim());
                        cmnd.Parameters.AddWithValue("_proc", textBox2.Text.Trim());
                        cmnd.Parameters.AddWithValue("_obs", textBox3.Text.Trim());

                        cmnd.ExecuteNonQuery();
                        GridFill();
                        clear();
                        sqlcon.Close();
                        textBox1.Text = textBox2.Text = textBox3.Text = "";
                        MessageBox.Show("Consulta guardada");
                        callhist();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                if (ArduinoPort.BytesToRead > 0)
                {

                    rfid = ArduinoPort.ReadLine().Substring(1);
                    rfid = rfid.Substring(0, rfid.Length - 1);
                    txtID.Text = rfid;



                    varid = 1;
                    if (dataGridView1.CurrentRow.Index != -1)
                    {

                        string par = rfid;
                        using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
                        {

                            sqlcon.Open();
                            MySqlCommand cmnd = new MySqlCommand("imgselect", sqlcon);
                            cmnd.CommandType = CommandType.StoredProcedure;
                            cmnd.Parameters.AddWithValue("_idpat", par);
                            cmnd.ExecuteNonQuery();
                            MySqlDataReader leer = cmnd.ExecuteReader();
                            if (leer.Read())
                            {
                                Bitmap nbitmap;
                                nbitmap = aImagen((byte[])leer["img"]);
                                pictureBox1.Image = new Bitmap(nbitmap, pictureBox1.Size);
                                pictureBox2.Image = new Bitmap(nbitmap, pictureBox2.Size);
                            }
                            sqlcon.Close();
                        }

                        txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txtapep.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        txtapem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        txted.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        combed.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        combsang.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        txtale.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        txtcurp.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        txtdir.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        txtnomcontacto.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                        txttelcon.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                        txtparcont.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                        //varid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value.ToString()); ;
                        button5.Text = "    Actualizar";
                        button6.Enabled = true;
                    }
                }
               
            }
            catch (Exception ex) { }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            //using (MySqlConnection sqlcon = new MySqlConnection(connectionsString))
            //{
            //    sqlcon.Open();
            //    MySqlCommand cmnd = new MySqlCommand("selbiod", sqlcon);
            //    cmnd.CommandType = CommandType.StoredProcedure;
            //    cmnd.ExecuteNonQuery();
            //    MySqlDataReader leer = cmnd.ExecuteReader();
            //    if (leer.Read())
            //    {
            //        Bitmap nbitmap;
            //        nbitmap = aImagen((byte[])leer["img"]);
            //        pictureBox1.Image = new Bitmap(nbitmap, pictureBox1.Size);
            //        pictureBox2.Image = new Bitmap(nbitmap, pictureBox2.Size);
            //    }
            //    sqlcon.Close();
            //}
            Random rnd = new Random();
            int pulso = rnd.Next(0, 5);
            int ox = rnd.Next(0, 5);
            int temp = rnd.Next(0, 5);

            label50.Text = pulso1[pulso];
            label48.Text = oxi1[ox];
            label52.Text = temp1[temp];
        }
    }
}
