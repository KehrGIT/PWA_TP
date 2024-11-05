using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Params
{
    public class TipoComprobante
    {
        public int TipoComprobanteId { get; set; }
        public string Nombre { get; set; }
        public int? PaisId { get; set; }
        public int TipoItemId { get; set; }
    }
}
