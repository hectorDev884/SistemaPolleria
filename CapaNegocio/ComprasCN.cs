using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ComprasCN
    {
        private ComprasCRUD _comprasCRUD = new ComprasCRUD();

        public void InsertarCompraCompleta(
            int proveedorID,
            DateTime fecha,
            decimal total,
            DataTable detalles)
        {
            _comprasCRUD.InsertarCompraCompleta(
                proveedorID,
                fecha,
                total,
                detalles);
        }

        public int ObtenerUltimaCompraID()
        {
            DataSet ds = _comprasCRUD.GetUltimaCompraID();
            return Convert.ToInt32(ds.Tables["GetUltimaCompraID"].Rows[0]["SiguienteCompraID"]);
        }

        public DataSet ObtenerComprasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _comprasCRUD.GetComprasPorFecha(fechaInicio, fechaFin);
        }

        public DataSet ObtenerComprasPorProveedor(int proveedorID)
        {
            return _comprasCRUD.GetComprasPorProveedor(proveedorID);
        }
    }
}