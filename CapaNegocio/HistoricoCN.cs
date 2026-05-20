using System;
using CapaDatos;
namespace CapaNegocio
{
    public class HistoricoCN
    {
        private HistoricoCRUD _historicoCRUD = new HistoricoCRUD();
        public void PasarVentasAHistorico(int anio)
        {
            _historicoCRUD.PasarVentasAHistorico(anio);
        }
        public void PasarComprasAHistorico(int anio)
        {
            _historicoCRUD.PasarComprasAHistorico(anio);
        }
        public void PasarLavadoPolloAHistorico(int anio)
        {
            _historicoCRUD.PasarLavadoPolloAHistorico(anio);
        }
        public void PasarClientesAHistorico()
        {
            _historicoCRUD.PasarClientesAHistorico();
        }
        public void PasarCategoriasAHistorico()
        {
            _historicoCRUD.PasarCategoriasAHistorico();
        }
        public void PasarProductosAHistorico()
        {
            _historicoCRUD.PasarProductosAHistorico();
        }
        public void PasarProveedoresAHistorico()
        {
            _historicoCRUD.PasarProveedoresAHistorico();
        }
        public void PasarTodoAHistorico(int? anio)
        {
            _historicoCRUD.PasarTodoAHistorico(anio);
        }
    }
}
