using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Auth
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
