using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
namespace Proyecto_Tienda
{
    public class ConexionSQLServer
    {
        public static SqlConnection con = null;
        public static string Ruta
        {
            get
            {
                return "Data Source=JOSEPABLO\\SQLEXPRESS;Initial Catalog=Proyecto_Tienda_DB;User ID=root;Password=admin";
            }
        }
        public static string Message { get; set; }
        public static SqlConnection Open()
        {
            con = null;
            try
            {
                con = new SqlConnection(Ruta);
                con.Open();
                Message = "[Conección Establecida]";
            }
            catch (Exception ex)
            {
                Message = "Ocurrió un grave error al intentar coenctarse con la base de datos " + ex.Message;
                con = null;
            }
            return con;
        }
        public static void Close()
        {
            con = null;
            Message = "[Conección Cerrada]";
        }
    }
}
