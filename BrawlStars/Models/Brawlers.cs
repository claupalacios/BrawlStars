using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TC_Vehiculos.Models
{
    public class Brawlers
    {
        public List<Gadget> gadgets { get; set; }
        public List<StarPower> starPowers { get; set; }
        public int id { get; set; }
        public int rank { get; set; }
        public int trophies { get; set; }
        public int highestTrophies { get; set; }
        public int power { get; set; }
        public JsonLocalizedName name { get; set; }
    }
}
