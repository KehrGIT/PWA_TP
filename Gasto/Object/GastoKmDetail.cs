using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto.Object
{
    public class GastoKmDetail
    {
        public int GastoId { get; set; } 
        public DateTime Fecha { get; set; }
        public decimal? TotalConvertido { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double? Kilometros { get; set; }
        public List<Models.Gasto.Object.CentroDeCosto> CentroDeCostoList { get; set; } = new List<CentroDeCosto>();
        public string Comentario { get; set; }        
        public string TicketPath { get; set; }
    }
}
