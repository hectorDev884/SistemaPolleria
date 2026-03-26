using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Pedido
    {
        private int _pedidoID;
        private int _clienteID;
        private DateTime _fecha;
        private bool _status;

        public int PedidoID
        {
            get { return _pedidoID; }
            set { _pedidoID = value; }
        }
        public int ClienteID
        {
            get { return _clienteID; }
            set { _clienteID = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
