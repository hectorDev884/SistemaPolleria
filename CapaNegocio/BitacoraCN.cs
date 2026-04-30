using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class BitacoraCN
    {
        private BitacoraCRUD _bitacoraCRUD = new BitacoraCRUD();

        public DataSet ObtenerErrors()
        {
            return _bitacoraCRUD.GetErrors();
        }
    }
}