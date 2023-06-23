using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Interfaces
{
    public interface LibrosInterface : IRepositoryBase<Libros>
    {
         List<Libros> ObtenerEntidadPorId(int Id);
    }
}
