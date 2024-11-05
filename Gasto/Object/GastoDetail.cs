using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CaolixAPI.Models.Gasto.Object
{
    public class GastoDetail
    {
        public int GastoId { get; set; }
        public int UsuarioId { get; set; }
        public int GastoTipoId { get; set; }
        public string ProveedorNombre { get; set; }
        public int? MedioDePagoId { get; set; }
        public string MedioDePagoNombre { get; set; }
        public int GastoEstadoId { get; set; }
        public DateTime Fecha { get; set; }
        public int? GastoCategoriaId { get; set; }
        public string GastoCategoriaNombre { get; set; }
        public string GastoCategoriaImageName { get; set; }
        public int? MonedaId { get; set; }
        public string MonedaNombre { get; set; }
        public string MonedaSimbolo { get; set; }
        public decimal TotalFinal { get; set; }
        public bool Incompleto { get; set; }
        public bool Bloqueado { get; set; }
        public string NroComprobante { get; set; }
        public string PuntoDeVenta { get; set; }
        public string PaisNombre { get; set; }
        public string TipoComprobanteNombre { get; set; }
        public int TipoComprobanteId { get; set; }
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }
        public string ProjectCode { get; set; }
        public string Comentario { get; set; }
        public string TicketPath { get; set; }
         
        public decimal Propina { get; set; }

        public decimal TotalGravado { get; set; }
        public decimal TotalIVA { get; set; }
        public string DataIVA { get; set; }

        public decimal NoGravado { get; set; }
        public int? Cantidad { get; set; }
        public int? CantidadComensales { get; set; }
        public string ListaComensales { get; set; }
        public string ProvinciaNombre { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double? Kilometros { get; set; }
        public double? KilometrosCalculados { get; set; }
        public double? Horas { get; set; }
        //public string CampoDinamico { get; set; }
        public Dictionary<string, string> CampoDinamico { get; set; }
        public IEnumerable<Models.Gasto.Object.CentroDeCosto> CentroDeCostoList { get; set; }
        public List<Models.Impuesto.GastoImpuesto> GastoImpuestoList { get; set; } = new List<Impuesto.GastoImpuesto>();
    }
}
