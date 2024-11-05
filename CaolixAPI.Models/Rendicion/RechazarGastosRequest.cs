using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class RechazarGastosRequest
    {
        public int RendicionId { get; set; }
        public IEnumerable<int> GastoIdList { get; set; }
        public int? RechazoMotivoId { get; set; }
        public string RechazoComentario { get; set; }
    }
}
