using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace biblioteca.Domain.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
        TEntity GetEntityById(int id);
        List<TEntity> GetEntities();
    }
}
