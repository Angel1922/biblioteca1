using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Domain.Repository
{
    public interface IRepositoryBase<TEntidad> where TEntidad : class
    {
        void Guardar(TEntidad entidad);
        void Actualizar(TEntidad entidad);
        TEntidad ObtenerEntidadPorId(int Id);
        List<TEntidad> ObtenerEntidades();

    }
}
