

using System.Collections.Generic;


namespace biblioteca.Domain.Repository
{
    internal interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Guardar(TEntity entity);
        void Actualizar(TEntity entiry);

        TEntity GetEntityById(int Id);
        List<TEntity> TraerEntities();

    }
}
