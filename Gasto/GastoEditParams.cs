using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto
{
    public class GastoEditParams
    {        
        public List<CaolixAPI.Models.Params.Pais> PaisList { get; set; } = new List<Params.Pais>();
        public List<CaolixAPI.Models.Params.TipoComprobante> TipoComprobanteList { get; set; } = new List<Params.TipoComprobante>();
        public List<CaolixAPI.Models.Params.Categoria> CategoriaList { get; set; } = new List<Params.Categoria>();        
    }
}
