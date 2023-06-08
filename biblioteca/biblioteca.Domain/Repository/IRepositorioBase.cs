using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace biblioteca.Domain.Repository
{
    public interface IRepositorioBase<TEntidad> where TEntidad : class
    {
        void Agregar(TEntidad entity);
        void Agregar(TEntidad[] entities);

        void Modificar(TEntidad entity);
        void Modificar(TEntidad[] entities);

        void Remover(TEntidad entity);
        void Remover(TEntidad[] entities);
        TEntidad TraerEntidad(int id);
        List<TEntidad> TraerEntidades();
        bool Existe(Expression<Func<TEntidad, bool>> filter);

        void GuardarCambios();
    }
}
