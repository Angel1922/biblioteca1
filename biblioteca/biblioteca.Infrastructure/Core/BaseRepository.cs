

using biblioteca.Domain.Repository;
using System.Collections.Generic;

namespace biblioteca.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public virtual void Actualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<TEntity> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Guardar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual TEntity TraerEntityporId(int Id)
        {
            throw new System.NotImplementedException();
        }

       // public abstract void miMetodo()
        
    }
}
