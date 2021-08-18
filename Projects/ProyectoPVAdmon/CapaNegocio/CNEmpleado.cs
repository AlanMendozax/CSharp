using System;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        //Instancias y declaracion de variables
        public static CDConexion Conexion = new CDConexion();
        private CDEmpleado objDato = new CDEmpleado();
        private String _Usuario;
        private String _Contraseña;

        public String Usuario
        {
            set
            {
                if (value == "USUARIO")
                {
                    _Usuario = "Ingrese un usuario, por favor";
                }
                else
                {
                    _Usuario = value;
                }
            }
            get { return _Usuario; }
        }

        public String Contraseña
        {
            set
            {
                if (value == "CONTRASEÑA")
                {
                    _Contraseña = "Ingrese su contraseña, por favor";
                }
                else
                {
                    _Contraseña = value;
                }

            }
            get { return _Contraseña; }
        }

        //Constructor vacio
        public CNEmpleado()
        {

        }

        //Metodo de recuperacion de contraseña
        public String RecuPass(string idUsuario)
        {
            string Mensaje;
            Mensaje = objDato.RecuperarContraseña(idUsuario);
            return Mensaje;
        }

        //Metodo de inicio de sesion
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSesion(_Usuario, _Contraseña);
            return Loguear;
        }

        //Metodo para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = objDato.MostrarUsuarios();
            return tabla;
        }

        //Metodo para insertar usuario
        public void InsertarUsuario( string Nombres, string Apellidos, string Telefono, string Correo, string Cargo, string Contraseña)
        {
            objDato.InsertarUsuario( Nombres, Apellidos, Telefono, Correo, Cargo, Contraseña);
        }

        //Metodo para editar usuario
        public void EditarUsuario( string Nombres, string Apellidos, string Telefono, string Correo, string Cargo, string IdEmpleado)
        {
            objDato.EditarUsuario( Nombres, Apellidos, Telefono, Correo, Cargo, IdEmpleado);
        }

        //Metodo para eliminar usuario
        public void EliminarUsuario(string IdEmpleado)
        {
            objDato.EliminarUsuario(IdEmpleado);
        }

        //Metodo para buscar usuario
        public void BuscarUsuario(string Nombre, string Apellido, string Telefono, string Cargo)
        {
            objDato.BuscarUsuario(Nombre, Apellido, Telefono, Cargo);
        }
    }
}
