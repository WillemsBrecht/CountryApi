using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace CountryApi.Models
{
    public class Country
    {
        // Dit is de code voor een land bvb. België => BE/BEL
        [KeyAttribute]
        public string ISOCode { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public int Population { get; set; }
    }
}
