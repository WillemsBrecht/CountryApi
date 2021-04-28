using System;
using System.ComponentModel.DataAnnotations;

namespace CountryApi.Models
{
    public class Result
    {
        [RequiredAttribute]
        public bool Success { get; set; }
        [RequiredAttribute]
        public string Message { get; set; }
    }
}
