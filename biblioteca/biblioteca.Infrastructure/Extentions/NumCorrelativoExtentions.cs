using biblioteca.Domain.Entities;
using biblioteca.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Extentions
{
    public static class NumCorrelativoExtention
    {
        public static NumCorrelativoModel ConvertirNumCorrelativoEntityaModel(this NumeroCorrelativo numcorrelativo)
        {
            NumCorrelativoModel correlativoModel = new NumCorrelativoModel()
            {
                NumeroCorrelativoID = numcorrelativo.IdNumeroCorrelativo,
                prefijo = numcorrelativo.Prefijo,
                ultimoNumero = numcorrelativo.UltimoNumero,
                fechaRegistro = numcorrelativo.FechaRegistro,
                tipo = numcorrelativo.Tipo
            };
            return correlativoModel;
        }


    }
}
