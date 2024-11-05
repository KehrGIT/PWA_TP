using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.CuentaCorriente.Object
{
    public class CuentaCorrienteList
    {
        public int CuentaCorrienteId { get; set; }
        public string RendicionCategoriaNombre { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
