using System;
using System.Text.Json.Serialization;

namespace CountryApi.Models
{
    public class UserCountry
    {
        [JsonIgnore]
        public Guid UserId { get; set; }
        public string ISOCode { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
