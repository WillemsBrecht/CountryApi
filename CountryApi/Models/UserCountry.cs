using System;

namespace CountryApi.Models
{
    public class UserCountry
    {
        public Guid UserId { get; set; }
        public string ISOCode { get; set; }
        public User User { get; set; }
    }
}
