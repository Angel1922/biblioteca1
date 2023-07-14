

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace biblioteca.Domain.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Guardar(TEntity entity);
        void Guardar(TEntity[] entities);
        void Actualizar(TEntity entity);
        void Actualizar(TEntity[] entities);

        void Eliminar(TEntity entity);
        void Eliminar(TEntity[] entities);

        TEntity TraerEntityporId(int Id);
        List<TEntity> GetEntities();

        bool Exists(Expression<Func<TEntity, bool>> filter);

        void SaveChanges();


    }
}
