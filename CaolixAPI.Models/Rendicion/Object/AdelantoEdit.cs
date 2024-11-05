using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion.Object
{
    public class AdelantoEdit
    {
        public int AdelantoId { get; set; }
        public DateTime Fecha { get; set; }
        public int? CentroDeCostoId { get; set; }
        public int? MotivoId { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public int? MonedaId { get; set; }
        public DateTime? FechaNecesidad { get; set; }
        public string Comentario { get; set; }
    }
}
