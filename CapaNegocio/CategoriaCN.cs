using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CategoriasCN
    {
        private CategoriasCRUD _categoriasCRUD = new CategoriasCRUD();
        public DataSet ObtenerCategorias()
        {
            return _categoriasCRUD.ObtenerCategorias();
        }

        public DataSet ObtenerCategoriaPorId(int id)
        {
            return _categoriasCRUD.ObtenerCategoriaPorID(id);
        }
        public int InsertarCategoria(
            string nombre,
            string descripcion)
        {
            return _categoriasCRUD.InsertarCategoria(
                nombre,
                descripcion);
        }

        public void ActualizarCategoria(
            int categoriaID,
            string nombre,
            string descripcion)
        {
            _categoriasCRUD.ActualizarCategoria(
                categoriaID,
                nombre,
                descripcion);
        }

        public void EliminarCategoria(int categoriaID)
        {
            _categoriasCRUD.EliminarCategoria(categoriaID);
        }
    }
}