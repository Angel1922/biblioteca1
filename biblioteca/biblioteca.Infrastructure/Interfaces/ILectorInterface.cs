using biblioteca.Domain.Entities;
using biblioteca.Domain.Repository;
using System.Collections.Generic;


namespace biblioteca.Infrastructure.Interfaces
{
    public interface ILectorInterface :IRepositoryBase<Lector>
    {
        public List<Lector> GetLectorByEstado(bool estado);
    }
}
