using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Impuesto
{
    public class Impuesto
    {
        public int impuestoId;
        public string nombre;
        public bool usaProvincia = false;
        public bool permiteMultiples = false;
        public int TipoComprobanteId { get; set; }
    }
}
