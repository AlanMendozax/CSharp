using System;
using System.Collections.Generic;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    class clsVentas
    {
        CDConexion M = new CDConexion();

        public int IdEmpleado { get; set; }
        public string Serie { get; set; }
        public string NroComprobante { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        public String GenerarSerieDocumento()
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            String Serie = "";
            try
            {
                lst.Add(new CDEmpleado("@Serie", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                M.EjecutarSP("[Serie Documento]", ref lst);
                Serie = Convert.ToString(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(Serie);
        }

        public String NumeroComprobante(String objTipoDocumento)
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            String NroCorrelativo = "";
            try
            {
                lst.Add(new CDEmpleado("@TipoDocumento", objTipoDocumento));
                lst.Add(new CDEmpleado("@NroCorrelativo", "", SqlDbType.VarChar, ParameterDirection.Output, 7));
                M.EjecutarSP("[Numero Correlativo]", ref lst);
                NroCorrelativo = Convert.ToString(lst[1].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(NroCorrelativo);
        }

        public String GenerarIdVenta()
        {
            List<CDEmpleado> lst = new List<CDEmpleado>();
            int objIdVenta;
            try
            {
                lst.Add(new CDEmpleado("@IdVenta", "", SqlDbType.Int, ParameterDirection.Output, 4));
                M.EjecutarSP("GenerarIdVenta", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }

        public String RegistrarVenta()
        {
            String Mensaje = "";
            List<CDEmpleado> lst = new List<CDEmpleado>();
            try
            {
                lst.Add(new CDEmpleado("@IdEmpleado", IdEmpleado));
                lst.Add(new CDEmpleado("@Serie", Serie));
                lst.Add(new CDEmpleado("@NroDocumento", NroComprobante));
                lst.Add(new CDEmpleado("@TipoDocumento", TipoDocumento));
                lst.Add(new CDEmpleado("@FechaVenta", FechaVenta));
                lst.Add(new CDEmpleado("@Total", Total));
                lst.Add(new CDEmpleado("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarVenta", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
