using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        private int _productoID;
        private string _codigoProducto;
        private string _nombre;
        private int _existencia;
        private decimal _precioVenta;
        private bool _status;
        private int _categoriaID;
        private string _unidadMedida;

        public int ProductoID
        {
            get { return _productoID; }
            set { _productoID = value; }
        }
        public string CodigoProducto
        {
            get { return _codigoProducto; }
            set { _codigoProducto = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }
        public decimal PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public int CategoriaID
        {
            get { return _categoriaID; }
            set { _categoriaID = value; }
        }
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
    }
}
