using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class RendicionSendRequest : Shared.RequestById
    {
        public int? AdelantoId { get; set; }
    }
}
