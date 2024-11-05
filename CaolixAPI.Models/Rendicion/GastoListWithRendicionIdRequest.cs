using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class GastoListWithRendicionIdRequest
    {
        public IEnumerable<Shared.Object.GenericDataSource> GastoIdWithDescriptionList { get; set; }
        public int RendicionId { get; set; }
    }
}
