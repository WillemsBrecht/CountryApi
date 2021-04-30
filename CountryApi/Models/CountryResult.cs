using System;
using System.Collections.Generic;

namespace CountryApi.Models
{
    public class CountryResult : Result
    {
        public CountryResult(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }

        public List<Country> CountryList { get; set; }
        public Country OneCountry { get; set; }
    }
}
