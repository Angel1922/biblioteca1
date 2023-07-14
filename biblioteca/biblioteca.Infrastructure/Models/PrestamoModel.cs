using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Models
{
    public class PrestamoModel
    {
        public int PrestamoId { get; set; }
        public int? LectorId { get; set; }
        public int? LibroId { get; set; }
        public bool? Estado { get; set; }
        public object IdPrestamo { get; internal set; }
    }
    
}
