using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Interfaces
{
    public interface INumCorrelativoRepository : IRepositoryBase<NumeroCorrelativo>
    {
        List<NumCorrelativoModel> ObtenerNum();
        List<NumCorrelativoModel> ObtenerNumCorrelativo(int IdNumeroCorrelativo);
        NumCorrelativoModel obtenerNumCorrelativo(int IdNumeroCorrelativo);
    }
}
