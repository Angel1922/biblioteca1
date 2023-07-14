using biblioteca.Domain.Entities;
using biblioteca.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Extentions
{
    public static class PrestamoExtention
    {
        public static PrestamoModel ConvertirPrestamoEntityaModel(this Prestamo prestamo)
        {
            PrestamoModel prestamoModel = new PrestamoModel()
            {
                PrestamoId = prestamo.IdPrestamo,
                LectorId = prestamo.IdLector,
                LibroId = prestamo.IdLibro,
                Estado = prestamo.Estado
            };
            return prestamoModel;
        }


    }
    }
