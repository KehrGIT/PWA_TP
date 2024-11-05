using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Shared
{
    public class RequestByGuidListId
    {
        public IEnumerable<Guid> Ids { get; set; }
    }
}
