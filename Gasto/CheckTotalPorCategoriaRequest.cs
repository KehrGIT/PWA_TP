using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto
{
    public class CheckTotalPorCategoriaRequest
    {
        public int GastoCategoriaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public int GastoId { get; set; }
        public int MonedaId { get; set; }
        public int Multiplicador { get; set; } = 1;
    }
}
