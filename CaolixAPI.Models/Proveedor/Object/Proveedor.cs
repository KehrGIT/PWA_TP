using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Proveedor.Object
{
    public class Proveedor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public bool EsValido { get; set; }
    }
}
