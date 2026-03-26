using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class ProveedoresCN
    {
        private ProveedoresCRUD _proveedoresCRUD = new ProveedoresCRUD();

        public DataSet ObtenerProveedores()
        {
            return _proveedoresCRUD.ObtenerProveedores();
        }

        public DataSet ObtenerProveedorPorId(int id)
        {
            return _proveedoresCRUD.ObtenerProveedorPorID(id);
        }

        public int InsertarProveedor(
            string nombre,
            string telefono,
            string direccion,
            bool status)
        {
            return _proveedoresCRUD.InsertarProveedor(
                nombre,
                telefono,
                direccion,
                status);
        }

        public void ActualizarProveedor(
            int id,
            string nombre,
            string telefono,
            string direccion,
            bool status)
        {
            _proveedoresCRUD.ActualizarProveedor(
                id,
                nombre,
                telefono,
                direccion,
                status);
        }

        public void EliminarProveedor(int id)
        {
            _proveedoresCRUD.EliminarProveedor(id);
        }
    }
}
