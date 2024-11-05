using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Notificacion
{
    public class NotificacionPending
    {
        public Guid NotificacionId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int? GastoId { get; set; }
        public int? RendicionId { get; set; }
        public string Descripcion { get; set; }
        public int? TipoGastoId { get; set; }
        public DateTime? FechaLeido { get; set; }
    }
}
