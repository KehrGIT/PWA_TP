using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto
{
    public class GastoListResponse
    {
        public List<Models.Gasto.Object.GastoList> GastoList { get; set; } = new List<Object.GastoList>();
    }
}
