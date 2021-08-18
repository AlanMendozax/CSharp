using System;
using System.Collections.Generic;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    class clsDetalleVenta
    {
        CDConexion M = new CDConexion();
        public Int32 IdProducto { get; set; }
        public Int32 IdVenta { get; set; }
        public Int32 Cantidad { get; set; }
        public Decimal PUnitario { get; set; }       
        public Decimal SubTotal { get; set; }

        public String RegistrarDetalleVenta()
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            String Mensaje = "";
            try
            {
                lst.Add(new CDEmpleado("@IdProducto", IdProducto));
                lst.Add(new CDEmpleado("@IdVenta", IdVenta));
                lst.Add(new CDEmpleado("@Cantidad", Cantidad));
                lst.Add(new CDEmpleado("@PrecioUnitario", PUnitario));               
                lst.Add(new CDEmpleado("@SubTotal", SubTotal));
                lst.Add(new CDEmpleado("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarDetalleVenta", ref lst);
                Mensaje = lst[6].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
