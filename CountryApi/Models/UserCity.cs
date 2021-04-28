using System;
using System.Text.Json.Serialization;

namespace CountryApi.Models
{
    public class UserCity
    {
        [JsonIgnore]
        public Guid UserId { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }
    }
}
