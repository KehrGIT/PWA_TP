using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Usuario
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PaisId { get; set; }
        public string PaisCodigoISO { get; set; }
        public int? SedeId { get; set; }
        public int? SedePaisId { get; set; }
        public int? JerarquiaId { get; set; }
        public bool Aprobador { get; set; }

        public string CountryCultureString { get; set; }
        public bool MostrarCentrodeCostosEnGasto { get; set; }        
        public bool MultiplesCentrosdeCostosEnGasto { get; set; }
        public int? CentroDeCostosDefault { get; set; }

        public bool MostrarCentrodeCostosEnAdelanto { get; set; }
        public bool MostrarMotivoEnAdelanto { get; set; }
        public bool MostrarComentarioEnAdelanto { get; set; }
    }
}
