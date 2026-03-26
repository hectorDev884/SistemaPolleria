using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductosCN
    {
        private ProductosCRUD _productosCRUD = new ProductosCRUD();

        public DataSet ObtenerProductos()
        {
            return _productosCRUD.ObtenerProductos();
        }

        public DataSet ObtenerProductoPorCodigo(string codigo)
        {
            return _productosCRUD.ObtenerProductoPorCodigo(codigo);
        }

        public int InsertarProducto(
            string codigoProducto,
            string nombre,
            int existencia,
            decimal precioVenta,
            bool status,
            int categoriaID,
            string unidadMedida)
        {
            return _productosCRUD.InsertarProducto(
                codigoProducto,
                nombre,
                existencia,
                precioVenta,
                status,
                categoriaID,
                unidadMedida);
        }

        public void ActualizarProducto(
            int productoID,
            string codigoProducto,
            string nombre,
            int existencia,
            decimal precioVenta,
            bool status,
            int categoriaID,
            string unidadMedida)
        {
            _productosCRUD.ActualizarProducto(
                productoID,
                codigoProducto,
                nombre,
                existencia,
                precioVenta,
                status,
                categoriaID,
                unidadMedida);
        }

        public void EliminarProducto(int productoID)
        {
            _productosCRUD.EliminarProducto(productoID);
        }

        public DataSet ObtenerProductosPorCategoria(int categoriaID)
        {
            return _productosCRUD.ObtenerProductosPorCategoria(categoriaID);
        }
    }
}