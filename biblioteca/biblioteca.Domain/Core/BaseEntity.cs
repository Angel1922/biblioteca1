using System;

namespace biblioteca.Domain.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.FechaCreacion = DateTime.Now;
            this.Eliminado = false;
        }
        public DateTime FechaCreacion { get; set; }
        public bool Eliminado { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaEliminado { get; set; }
        public string? UsuarioEliminado { get; set; }
    }
}
