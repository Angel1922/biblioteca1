using biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Context
{
    public partial class BibliotecaContext : DbContext
    {
        public BibliotecaContext() 
        {
        
        }
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        { 
        }

        public DbSet<Prestamo> Prestamo { get; set; }
    
    }
}
