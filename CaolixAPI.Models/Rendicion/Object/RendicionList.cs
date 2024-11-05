using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Rendicion.Object
{
    public class RendicionList
    {
        public int RendicionId { get; set; }
        public int RendicionEstadoId { get; set; }
        public string RendicionEstadoNombre { get; set; }
        public string Nombre { get; set; }
        public decimal? Monto { get; set; }
        public int TipoRendicionId { get; set; }
        public int? RendicionCategoriaId { get; set; }
        public string RendicionCategoriaNombre { get; set; }
        public DateTime Fecha { get; set; } 
        public int MonedaId { get; set; }
        public string MonedaNombre { get; set; }
        public string MonedaSimbolo { get; set; }
        public int CantidadGastos { get; set; }
        public int UsuarioCreadorId { get; set; }
        public string UsuarioCreadorNombre { get; set; }
    }
}
