using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Core;
using biblioteca.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace biblioteca.Infrastructure.Repositories
{
    public class LibrosRepository : BaseRepository<Libros>, LibrosInterface
    { 
       
        List<Libros> LibrosInterface.ObtenerEntidadPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
