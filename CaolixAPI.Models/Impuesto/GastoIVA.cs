using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Impuesto
{
    public class GastoIVA
    {
        public int IVAId { get; set; }
        public decimal Gravado { get; set; }
        public decimal IVA { get; set; }
    }
}
