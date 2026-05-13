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
    }
}
