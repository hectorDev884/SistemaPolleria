using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class DetalleVenta
    {
        private int _detalleVentaID;
        private int _ventaID;
        private int _productoID;
        private decimal _precioUnitario;
        private int _cantidad;
        private decimal _subtotal;

        public int DetalleVentaID
        {
            get { return _detalleVentaID; }
            set { _detalleVentaID = value; }
        }
        public int VentaID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }
        public int ProductoID
        {
            get { return _productoID; }
            set { _productoID = value; }
        }
        public decimal PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
    }
}
