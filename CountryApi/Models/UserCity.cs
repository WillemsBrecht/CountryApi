using System;
using System.Text.Json.Serialization;

namespace CountryApi.Models
{
    public class UserCity
    {
        public Guid UserId { get; set; }
        public Guid CityId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
