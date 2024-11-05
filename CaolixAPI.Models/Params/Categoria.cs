using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Params
{
    public class Categoria
    {
        public int GastoCategoriaId { get; set; }
        public string Nombre { get; set; }
        public bool ComentarioObligatorio { get; set; }
        public bool PideComensalesCantidad { get; set; }
        public bool PideKm { get; set; }
        public bool PideLitros { get; set; }
        public bool PidePatente { get; set; }
        public int? MontoMaximo { get; set; }
    }
}
