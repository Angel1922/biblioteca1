using biblioteca.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Core
{
    public abstract class BaseRepository<TEntidad> : IRepositoryBase<TEntidad> where TEntidad : class
    {
        public virtual void Actualizar(TEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public virtual void Guardar(TEntidad entidad)
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntidad> ObtenerEntidades()
        {
            throw new NotImplementedException();
        }

        public virtual TEntidad ObtenerEntidadPorId(int Id)
        {
            throw new NotImplementedException();
        }
        
    }
}
