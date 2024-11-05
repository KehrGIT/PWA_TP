using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Auth
{
    public class LoginResponse
    {
        public Usuario.Usuario Usuario { get; set; }
        public string JWT { get; set; }
    }
}
