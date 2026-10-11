using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class NumeroCorrelativo
    {
        public int IdNumeroCorrelativo { get; set; }
        public int? Ultimonumero { get; set; }
        public int? CantidadDigitos { get; set; }
        public string? Gestion { get; set; }
        public DateTime? FechaActalizacion { get; set; }
    }
}
