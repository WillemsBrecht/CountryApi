using System.Net.Mail;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CountryApi.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Mail { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public List<UserCountry> VisitedCountries { get; set; }
    }
}
