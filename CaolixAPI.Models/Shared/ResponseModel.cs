using System;
using System.Collections.Generic;
using System.Text;

namespace CaolixAPI.Models.Shared
{
    public class ResponseModel<T> where T : new()
    {
        public T Entity { get; set; } = new T();

    }
}
