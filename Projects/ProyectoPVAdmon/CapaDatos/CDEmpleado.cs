using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace CapaDatos
{
    public class CDEmpleado
    {
        private String m_Nombre;
        private Object m_Valor;
        private SqlDbType m_TipoDato;
        private ParameterDirection m_Direccion;
        private int m_Tamaño;
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;
        private SqlCommand Comando = new SqlCommand();
        private String Email, Nombres, Contraseña, Mensaje;
        DataTable tabla = new DataTable();        

        public String Nombre
        {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }

        public Object Valor
        {
            get { return m_Valor; }
            set { m_Valor = value; }
        }

        public SqlDbType TipoDato
        {
            get { return m_TipoDato; }
            set { m_TipoDato = value; }
        }

        public ParameterDirection Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public int Tamaño
        {
            get { return m_Tamaño; }
            set { m_Tamaño = value; }
        }

        public CDEmpleado(String objNombre, Object objValor)
        {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_Direccion = ParameterDirection.Input;
        }

        public CDEmpleado(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_TipoDato = objTipoDato;
            m_Direccion = objDireccion;
            m_Tamaño = objTamaño;
        }

        //Metodo de recuperacion de contraseña
        public String RecuperarContraseña(string idUsuario)
        {
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "SELECT * FROM Empleado WHERE IdEmpleado='" + idUsuario + "'";
            leer = Comando.ExecuteReader();
            if (leer.Read() == true)
            {
                Email = leer["Correo"].ToString();
                Nombres = leer["Nombres"].ToString() + " " + leer["Apellidos"].ToString();
                Contraseña = leer["Contraseña"].ToString();
                EnviarEmail();
                Mensaje = "Estimado " + Nombres + ", se ha enviado su contraseña al correo: " + Email + "; Verifique su bandeja de entrada.";
                leer.Close();
                Comando.Parameters.Clear();
                Conexion.Desconectar();
            }
            else
            {
                Mensaje = "No existen datos ...";
            }
            leer.Close();
            Conexion.Desconectar();
            return Mensaje;
        }

        //Metodo de envio de correo electronico para la recuperacion de la contraseña
        public void EnviarEmail()
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("itsppsistemas@gmail.com");
            Correo.To.Add(Email);
            Correo.Subject = ("RECUPERAR CONTRASEÑA SYSTEM");
            Correo.Body = "Hola, " + Nombres + " usted solicito recuperar su contraseña\n Su contraseña es: " + Contraseña;
            Correo.Priority = MailPriority.Normal;
            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("itsppsistemas@gmail.com", "itspp1234");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;
            try
            {
                ServerMail.Send(Correo);
            }
            catch (Exception ex)
            {

            }
            Correo.Dispose();
        }

        //Metodo de inicio de sesion
        public SqlDataReader IniciarSesion(string user, string pass)
        {
            SqlCommand comando = new SqlCommand("InicioSesion", Conexion.Conectar());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", user);
            comando.Parameters.AddWithValue("@pass", pass);
            leer = comando.ExecuteReader();
            return leer;
        }

        //Metodo para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            Conexion.Desconectar();
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "ShowUser";
            Comando.CommandType = CommandType.StoredProcedure;
            leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            tabla.Load(leer);
            leer.Close();
            Conexion.Desconectar();
            return tabla;
        }

        //Metodo de insertar usuario
        public void InsertarUsuario( string Nombres, string Apellidos, string Telefono, string Correo, string Cargo, string Contraseña)
        {
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "InsUser";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombres", Nombres);
            Comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            Comando.Parameters.AddWithValue("@Telefono", Telefono);
            Comando.Parameters.AddWithValue("@Correo", Correo);
            Comando.Parameters.AddWithValue("@Car", Cargo);
            Comando.Parameters.AddWithValue("@Pass", Contraseña);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            tabla.Clear();
            MostrarUsuarios();
            Conexion.Desconectar();
        }

        //Metodo de editar usuario
        public void EditarUsuario( string Nombres, string Apellidos, string Telefono, string Correo,string Cargo, string IdEmpleado)
        {
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "EditUser";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombres);
            Comando.Parameters.AddWithValue("@Apellido", Apellidos);
            Comando.Parameters.AddWithValue("@Telefono", Telefono);
            Comando.Parameters.AddWithValue("@Correo", Correo);
            Comando.Parameters.AddWithValue("@Car", Cargo);
            Comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            tabla.Clear();
            MostrarUsuarios();
            Conexion.Desconectar();
        }

        //Metodo de eliminar usuario
        public void EliminarUsuario(string IdEmpleado)
        {
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "DeleteUser";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            tabla.Clear();
            MostrarUsuarios();
            Conexion.Desconectar();
        }

        //Metodo de busqueda de usuarios
        public void BuscarUsuario(string Nombre, string Apellido, string Telefono, string Cargo)
        {
            tabla.DefaultView.RowFilter = $"Nombres LIKE '{Nombre}%'" + $"or Apellidos LIKE '{Apellido}%'" + $"or Cargo LIKE '{Cargo}%'" +
                  $"or Telefono LIKE '{Telefono}%'";
        }

        //Constructor vacio
        public CDEmpleado()
        {

        }
    }
}
