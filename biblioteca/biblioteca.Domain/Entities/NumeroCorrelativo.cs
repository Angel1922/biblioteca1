

using System;

namespace biblioteca.Domain.Entities
{
    public class NumeroCorrelativo
    {
        public int IdNumeroCorrelativo { get; set; }
        public string Prefijo { get; set; }
        public string Tipo { get; set;}
        public int UltimoNumero { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
