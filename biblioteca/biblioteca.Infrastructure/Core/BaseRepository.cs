using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;

namespace biblioteca.Infrastructure.Core
{
    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public virtual List<TEntity> GetEntities()
        {
            throw new System.NotImplementedException();
        }       
        public virtual void Guardar(NumeroCorrelativo entity)
        {
            throw new System.NotImplementedException();
        }
        public virtual void Actualizar(NumeroCorrelativo entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual TEntity GetEntityById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public abstract void miMetodo();
        
    }
}
