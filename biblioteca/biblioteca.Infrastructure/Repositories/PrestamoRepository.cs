
using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using biblioteca.Infrastructure.Core;
using System.Collections.Generic;

namespace biblioteca.Infrastructure.Repositories
{
    public class PrestamoRepository : BaseRepository<Prestamo>, IRepositoryBase<Prestamo>
    {
        public override List<Prestamo> GetEntities()
        {
            //adaptacion a nuestro requerimiento
            return new List<Prestamo>();
        }
    }
}
