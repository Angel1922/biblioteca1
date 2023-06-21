using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Domain.Core
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

        public virtual TEntity TraerEntityPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
