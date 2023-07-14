using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Models
{
    public class NumCorrelativoModel
    {
        public int NumeroCorrelativoID { get; set; }
        public string prefijo { get; set; }
        public string tipo { get; set; }
        public int ultimoNumero { get; set; }
        public DateTime? fechaRegistro { get; set; }
    }
}
