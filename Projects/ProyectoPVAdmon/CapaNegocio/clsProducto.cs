using System;
using System.Collections.Generic;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsProducto
    {
        private CDConexion M = new CDConexion();

        private Int32 m_IdP;
        private String m_Categoria;
        private String m_Producto;
        private String m_Marca;
        private Int32 m_Stock;        
        private Decimal m_PrecioVenta;        

        public Int32 IdP
        {
            get { return m_IdP; }
            set { m_IdP = value; }
        }

        public String Categoria
        {
            get { return m_Categoria; }
            set { m_Categoria = value; }
        }

        public String Producto
        {
            get { return m_Producto; }
            set { m_Producto = value; }
        }

        public String Marca
        {
            get { return m_Marca; }
            set { m_Marca = value; }
        }

        public Int32 Stock
        {
            get { return m_Stock; }
            set { m_Stock = value; }
        }

        public Decimal PrecioVenta
        {
            get { return m_PrecioVenta; }
            set { m_PrecioVenta = value; }
        }

        public DataTable Listar()
        {
            return M.Listado("ListadoProductos", null);
        }

        public DataTable BusquedaProductos(String objDatos)
        {
            DataTable dt = new DataTable();
            List<CDEmpleado> lst = new List<CDEmpleado>();
            try
            {
                lst.Add(new CDEmpleado("@Datos", objDatos));
                dt = M.Listado("FiltrarDatosProducto", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public String RegistrarProductos()
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            String Mensaje = "";

            try
            {
                lst.Add(new CDEmpleado("@Categoria", m_Categoria));
                lst.Add(new CDEmpleado("@Nombre", m_Producto));
                lst.Add(new CDEmpleado("@Marca", m_Marca));
                lst.Add(new CDEmpleado("@Stock", m_Stock));
                lst.Add(new CDEmpleado("@PrecioVenta", m_PrecioVenta));
                lst.Add(new CDEmpleado("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarProducto", ref lst);
                Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProductos()
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            String Mensaje = "";

            try
            {
                lst.Add(new CDEmpleado("@IdProducto", m_IdP));
                lst.Add(new CDEmpleado("@Categoria", m_Categoria));
                lst.Add(new CDEmpleado("@Nombre", m_Producto));
                lst.Add(new CDEmpleado("@Marca", m_Marca));
                lst.Add(new CDEmpleado("@Stock", m_Stock));
                lst.Add(new CDEmpleado("@PrecioVenta", m_PrecioVenta));
                lst.Add(new CDEmpleado("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ActualizarProducto", ref lst);
                Mensaje = lst[8].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
