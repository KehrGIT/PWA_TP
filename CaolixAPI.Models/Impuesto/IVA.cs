using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Impuesto
{
    public class IVA
    {
        public int IVAId { get; set; }
        public double Porcentaje { get; set; }
        public int Orden { get; set; }
        public int PaisId { get; set; }
    }
}
