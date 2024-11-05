using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.ComprobanteCampo
{
    public class ComprobanteCampoListRequest
    {
        public int TipoComprobanteId { get; set; }
        public bool LoadDataSource { get; set; }
    }
}
