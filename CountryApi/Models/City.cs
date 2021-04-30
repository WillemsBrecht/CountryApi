using System.ComponentModel.DataAnnotations;
using System;
using System.Text.Json.Serialization;

namespace CountryApi.Models
{
    public class City
    {
        public Guid CityId { get; set; }
        [RequiredAttribute]
        public string Name { get; set; }
        public int Population { get; set; }
        [JsonIgnore]
        public Country Country { get; set; }
        [RequiredAttribute]
        public string CountryISOCode { get; set; }
    }
}
