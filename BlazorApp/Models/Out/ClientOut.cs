using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models.Out
{
    public class ClientOut
    {
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        public string PostCode { get; set; }
        public string City { get; set; }
        [Required]
        [MinLength(1)]
        public string Street { get; set; }
        [Required]
        [MinLength(1)]
        public string Number { get; set; }
        [Required]
        [MinLength(10)]
        public string NIP { get; set; }
    }
}
