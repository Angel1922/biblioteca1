
using biblioteca.Domain.Core;
using System;

namespace biblioteca.Domain.Entities
{
    public class Libros : BaseEntity
    {
       public int IdLibro { get; set; }
       public string Titulo { get; set; }
        public string Autor { get; set; }
        public int IdCategoria { get; set; }
        public string Editorial { get; set; }
        public string Ubicacion { get; set; }
        public int Ejemplares { get; set; }
        public string Portada { get; set; }
        public bool Estado { get; set;}
        public DateTime FechaCreacion { get; set;}
       
    }
}
