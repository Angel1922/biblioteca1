

using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Models;
using System.Collections.Generic;

namespace biblioteca.Infrastructure.Interfaces
{
    public interface INumCorrelativo : IRepositoryBase<Prestamo>
    {
        List<PrestamoModel> ObtenerNumCorrelativo();
        List<PrestamoModel> ObtenerPrestamos(int IdPrestamo);
        PrestamoModel Obtenerprestamo(int IdPrestamo);
        void Guardar(NumeroCorrelativo correlativo);
        void Actualizar(NumeroCorrelativo correlativo);
    }
}
