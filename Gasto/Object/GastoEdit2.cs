using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Gasto.Object
{
    public class GastoEdit2
    {
        public int GastoId { get; set; }
        public int UsuarioId { get; set; }
        public string ProveedorNombre { get; set; }
        public int? MedioDePagoId { get; set; }
        public int GastoEstadoId { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoGastoId { get; set; }
        public int? GastoCategoriaId { get; set; }
        public int? MonedaId { get; set; }
        public decimal TotalFinal { get; set; }
        public decimal? Total { get; set; }
        public bool Incompleto { get; set; }
        public bool Bloqueado { get; set; }
        public string NroComprobante { get; set; }
        public int? PaisId { get; set; }
        public int? TipoComprobanteId { get; set; }
        public string CUIT { get; set; }        
        public string RazonSocial { get; set; }
        public string ProjectCode { get; set; }
        public string Comentario { get; set; }
        public string TicketPath { get; set; }
        public decimal? Propina { get; set; }
        public List<Models.Params.CentroDeCosto> CentroDeCostoList { get; set; } = new List<Params.CentroDeCosto>();
        public int? Cantidad { get; set; }
        public int? CantidadComensales { get; set; }
        public double? AutoKilometraje { get; set; }
        public double? AutoLitros { get; set; }
        public decimal? NoGravado { get; set; }
        public double? KilometrosRendidos { get; set; }
        public double? KilometrosCalculados { get; set; }
        public string NroLicencia { get; set; }
        public string Patente { get; set; }
        public string AutoPatente { get; set; } 
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int? ProvinciaId { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public string ListaComensales { get; set; }
        public int? ProveedorId { get; set; }
        public string Photo { get; set; }
        public string MapsPhotoURL { get; set; }
        public int? CantidadNoches { get; set; }
        public List<Models.Impuesto.GastoIVA> GastoIVAList { get; set; } = new List<Impuesto.GastoIVA>();
        public List<Models.Impuesto.GastoImpuesto> GastoImpuestoList { get; set; } = new List<Impuesto.GastoImpuesto>();
        public string CampoDinamicoJson { get; set; }

        public double? OrigenLat { get; set; }
        public double? OrigenLng { get; set; }
        public double? DestinoLat { get; set; }
        public double? DestinoLng { get; set; }
        public DateTime? VencimientoCAE { get; set; }
        public string CAE { get; set; }
    }
}
