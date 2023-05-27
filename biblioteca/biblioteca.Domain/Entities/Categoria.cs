using biblioteca.Domain.Core;
using System;

namespace biblioteca.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string? Descripcion { get; set; }

        public string? Estado { get; set; }

        public string? FechaCreacion { get; set; }
    }
}
