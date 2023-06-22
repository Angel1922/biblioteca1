using biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace biblioteca.Infrastructure.Context
{
    public partial class LectorContext : DbContext
    {
        public LectorContext()
        {

        }

        public LectorContext(DbContextOptions<LectorContext> options) : base(options)
        {

        }

        public DbSet<Lector> Lector { get; set; } 
    }
}
