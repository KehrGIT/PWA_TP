using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion.Object
{
    public class RendicionDetail
    {
        public int RendicionId { get; set; }
        public string Nombre { get; set; }
        public int? RendicionCategoriaId { get; set; }
        public string RendicionCategoriaNombre { get; set; }
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioCreadorId { get; set; }
        public string UsuarioCreadorNombre { get; set; }
        public int RendicionEstadoId { get; set; }
        public string RendicionEstadoNombre { get; set; }
        public decimal? Monto { get; set; }
        public int? MonedaId { get; set; }
        public string MonedaSimbolo { get; set; }
        public bool AccesoOpcionesAprobador { get; set; }
        public List<Gasto.Object.GastoList> GastoList { get; set; } = new List<Gasto.Object.GastoList>();
        public bool ImportAdelanto { get; set; }
    }
}
