using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Impuesto
{
    public class GastoImpuesto
    {
        public int ImpuestoId { get; set; }
        public decimal Monto { get; set; }
        public int? ProvinciaId { get; set; }
    }
}
