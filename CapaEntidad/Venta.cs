using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Venta
    {
        private int _ventaID;
        private DateTime _fecha;
        private decimal _total;
        private int? _pedidoID;

        public int VentaID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public int? PedidoID
        {
            get { return _pedidoID; }
            set { _pedidoID = value; }
        }
    }
}
