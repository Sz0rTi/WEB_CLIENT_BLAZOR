using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class LoginResult
    {
        public bool Successful { get; set; }
        public string Token { get; set; }
        public string Error { get; set; }
    }
}
