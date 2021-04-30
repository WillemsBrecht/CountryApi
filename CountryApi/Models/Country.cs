using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryApi.Models
{
    public class Country
    {
        // Dit is de code voor een land bvb. België => BE/BEL
        [KeyAttribute]
        [Required]
        public string ISOCode { get; set; }
        [Required]
        public string Name { get; set; }
        public int Population { get; set; }
        public List<City> Cities { get; set; }
    }
}
