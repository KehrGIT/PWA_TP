using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Auth
{
    public class CheckUpdateConfigResponse
    {
        public List<string> ConfigToUpdateList { get; set; } = new List<string>();
    }
}
