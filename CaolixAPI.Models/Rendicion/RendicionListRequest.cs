using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion
{
    public class RendicionListRequest
    {
        public int? RendicionId { get; set; }
        public decimal? MontoDesde { get; set; }
        public decimal? MontoHasta { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int? MedioDePagoId { get; set; }
        public int? RendicionEstadoId { get; set; }
        public int? RendicionCategoriaId { get; set; }
        public bool AprobacionesPendientes { get; set; }
    }
}
