

using System.Collections.Generic;

namespace biblioteca.Domain.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Guardar(TEntity entity);


        void Actualizar(TEntity entity);


        TEntity TraerEntityporId(int Id);
        List<TEntity> GetEntities();


    }
}
