using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ClientesCN
    {
        private ClientesCRUD _clientesCRUD = new ClientesCRUD();

        public DataSet ObtenerClientes()
        {
            return _clientesCRUD.ObtenerClientes();
        }

        public DataSet ObtenerClientePorId(int id)
        {
            return _clientesCRUD.ObtenerClientePorID(id);
        }
        public int InsertarCliente(string nombre,
                           string apellido,
                           string telefono,
                           bool status)
        {
            return _clientesCRUD.InsertarCliente(
                nombre, apellido, telefono, status);
        }

        public void ActualizarCliente(int id,
                              string nombre,
                              string apellido,
                              string telefono,
                              bool status)
        {
            _clientesCRUD.ActualizarCliente(
                id, nombre, apellido, telefono, status);
        }

        public void EliminarCliente(int id)
        {
            _clientesCRUD.EliminarCliente(id);
        }
    }
}
