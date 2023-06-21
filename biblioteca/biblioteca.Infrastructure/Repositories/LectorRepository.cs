using biblioteca.Domain.Core;
using biblioteca.Domain.Interfaces;

namespace biblioteca.Domain.Repositories
{
    internal class LectorRepository : , ILectorRepository
    {
        public override List<Lector> GetEntities()
        {
            // adaptacion a nuestro requerimiento
            return new List<LectorRepository>();
        }
    }
}
