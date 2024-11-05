using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.CuentaCorriente
{
    public class BalanceResponse
    {
        public decimal GastoTotal { get; set; }
        public decimal KilometrosTotal { get; set; }
        public int HorasTotal { get; set; }
        public decimal AdelantosTotal { get; set; }
        public List<Models.CuentaCorriente.Object.CuentaCorrienteList> CuentaCorrienteList { get; set; } = new List<Object.CuentaCorrienteList>();

    }
}
