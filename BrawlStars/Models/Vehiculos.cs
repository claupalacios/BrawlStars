using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TC_Vehiculos.Models
{
    public partial class Vehiculos
    {
        public int Id { get; set; }

        [Required]
        public string Patente { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public int? Puertas { get; set; }

        [Required]
        public string Titular { get; set; }
    }
}
