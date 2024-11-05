using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CaolixAPI.Models.Gasto.Object
{
    public class GastoList 
    {
        public int GastoId { get; set; }
        public int UsuarioId { get; set; }
        public string ProveedorNombre { get; set; }
        public int? MedioDePagoId { get; set; }
        public int GastoEstadoId { get; set; }
        public DateTime Fecha { get; set; }
        public int? GastoCategoriaId { get; set; }
        public string GastoCategoriaImageName { get; set; }
        public int? MonedaId { get; set; }
        public int? GastoOrigen { get; set; }
        public int GastoTipoComprobanteOrden { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string MonedaSimbolo { get; set; }
        public decimal TotalFinal { get; set; }
        public int TipoComprobanteId { get; set; }
        public bool Incompleto { get; set; }
        public bool Bloqueado { get; set; }
        public bool Combinado { get; set; }
        public bool Importado { get; set; }
        public bool EsGastoKm { get; set; }
        public bool EsGastoHs { get; set; }
        public bool ExcedePoliticas { get; set; }
    }
}
