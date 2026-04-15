using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VentasCN
    {
        private VentasCRUD _ventasCRUD = new VentasCRUD();

        public int InsertarPedido(int clienteID)
        {
            return _ventasCRUD.InsertarPedido(clienteID);
        }

        public int InsertarVenta(
            DateTime fecha,
            decimal total,
            int? pedidoID)
        {
            return _ventasCRUD.InsertarVenta(
                fecha,
                total,
                pedidoID);
        }

        public void InsertarDetalleVenta(
            int ventaID,
            int productoID,
            decimal precioUnitario,
            int cantidad,
            decimal subtotal)
        {
            _ventasCRUD.InsertarDetalleVenta(
                ventaID,
                productoID,
                precioUnitario,
                cantidad,
                subtotal);
        }

        public void InsertarVentaCompleta(
            DateTime fecha,
            decimal total,
            int? clienteID,
            DataTable detalles)
        {
            _ventasCRUD.InsertarVentaCompleta(
                fecha,
                total,
                clienteID,
                detalles);
        }

        public int ObtenerUltimaVentaID()
        {
            DataSet ds = _ventasCRUD.GetUltimaVentaID();
            return Convert.ToInt32(ds.Tables["GetUltimaVentaID"].Rows[0]["SiguienteVentaID"]);
        }

        public DataTable GetVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _ventasCRUD.GetVentasPorFecha(fechaInicio, fechaFin)
                              .Tables["GetVentasPorFecha"];
        }

        public DataSet ObtenerVentasPorCliente(int clienteID)
        {
            return _ventasCRUD.GetVentasPorCliente(clienteID);
        }

        public DataSet ObtenerTopProductosVendidos(int top)
        {
            return _ventasCRUD.GetTopProductosVendidos(top);
        }
    }
}