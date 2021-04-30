using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CountryApi.Models
{
    public class CityResult : Result
    {
        public CityResult(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }
        public List<City> CityList { get; set; }
        public City OneCity { get; set; }
    }
}
