using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class SendAprobadorRendicionRequest
    {
        public int RendicionId { get; set; }
        public string ComentarioAprobador { get; set; }
    }
}
