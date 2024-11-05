using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.ComprobanteCampo.Object
{
    public class ComprobanteCampo
    {
        public int ComprobanteCampoId { get; set; }
        public string ComprobanteCampoNombre { get; set; }
        public int TipoComprobanteCampoId { get; set; }        
        public bool Requerido { get; set; }
        public string Mask { get; set; }
        public int Orden { get; set; }
        public string PlaceHolder { get; set; }
        public string Formula { get; set; }
        public string Formato { get; set; }
        public string Visibilidad { get; set; }
        public bool SiempreNegativo { get; set; }
        public int TipoComprobanteId { get; set; }
        public int TipoItemId { get; set; }
        public List<CaolixAPI.Models.Shared.Object.GenericDataSource> DataSource { get; set; } = new List<CaolixAPI.Models.Shared.Object.GenericDataSource>();
    }
}
