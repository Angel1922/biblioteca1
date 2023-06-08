using biblioteca.Domain.Core;
using System;

namespace biblioteca.Domain.Entities
{
    public class Lector : BaseEntity
    {
        public int IdLector { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public bool Estado { get; set; }
    }
}
