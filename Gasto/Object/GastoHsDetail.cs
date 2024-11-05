using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto.Object
{
    public class GastoHsDetail
    {
        public int GastoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Horas { get; set; }
        public string Comentario { get; set; }
        public string PaisNombre { get; set; }        
    } 
}
