using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductoLavadoCN
    {
        private ProductoLavadoCRUD _productoLavadoCRUD = new ProductoLavadoCRUD();

        public int InsertarLavadoPollo(
            DateTime fecha,
            int productoALavarID,
            int productoLavadoID,
            decimal cantidadALavar,
            decimal cantidadDesperdicios)
        {
            return _productoLavadoCRUD.InsertarLavadoPollo(
                fecha,
                productoALavarID,
                productoLavadoID,
                cantidadALavar,
                cantidadDesperdicios);
        }

        public DataTable ObtenerLavados()
        {
            DataSet ds = _productoLavadoCRUD.ObtenerLavados();
            return ds.Tables["GetLavadoPollo"];
        }

        public DataTable ObtenerLavadoPorID(int lavadoPolloID)
        {
            DataSet ds = _productoLavadoCRUD.ObtenerLavadoPorID(lavadoPolloID);
            return ds.Tables["GetLavadoPolloByID"];
        }

        public DataSet ObtenerLavadosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _productoLavadoCRUD.GetLavadosPorFecha(fechaInicio, fechaFin);
        }
        public DataSet ObtenerResumenDesperdicioPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _productoLavadoCRUD.GetResumenDesperdicioPorFecha(fechaInicio, fechaFin);
        }
    }
}