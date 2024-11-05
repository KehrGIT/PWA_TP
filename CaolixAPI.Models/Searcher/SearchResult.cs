using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Searcher
{
    public class SearchResult
    {
        public Models.Gasto.Object.GastoList Gasto { get; set; } 
        public Models.Rendicion.Object.RendicionList Rendicion { get; set; } 
    }
}
