using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer
{
    public class ApiResponse
    {
        public string Mesaage { get; set; }
        public bool Ok { get; set; }
        public int Status { get; set; }
        public string Token { get; set; }
        public dynamic Data { get; set; }

    }
}
