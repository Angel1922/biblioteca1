

using System;


namespace biblioteca.Domain.Entities
{
    public class Prestamo
    {
        
        public int IdPrestamo { get; set; }
        public string? Codigo { get; set; }
        public int? IdEstadoPrestamo { get; set; }
        public int? IdLector { get; set; }
        public int? IdLibro { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public DateTime? FechaConfirmacionDevolucion { get; set; }
        public string? EstadoEntregado { get; set; }
        public string? EstadoRecibido { get; set; }
        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

    }
}
