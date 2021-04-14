using System;

namespace CountryApi.Models
{
    public class City
    {
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public string ISOCode { get; set; }
        public Country Country { get; set; }
    }
}
