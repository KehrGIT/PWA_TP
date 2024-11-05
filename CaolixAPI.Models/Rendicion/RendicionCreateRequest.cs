using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class RendicionCreateRequest
    {
        public int? RendicionCategoriaId { get; set; }
        public int RendicionSubTipoRendicionId { get; set; }
        public string RendicionNombre { get; set; }
        public string RendicionComentarios { get; set; }
        public List<Models.Rendicion.Object.SubTipoRendicionDatoAdicional> DatosAdicionales { get; set; } = new List<Models.Rendicion.Object.SubTipoRendicionDatoAdicional>();
        public List<Models.Gasto.Object.GastoList> GastoList { get; set; } = new List<Gasto.Object.GastoList>();
    }
}
