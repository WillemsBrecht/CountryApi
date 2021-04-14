using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountryApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class VisitController: ControllerBase
    {  
        private readonly ICountryService _countryService;

        public VisitController(ICountryService countryService)
        {
            this._countryService = countryService;
        }

        [HttpGet]
        [Route("countries")]
        public async Task<ActionResult<List<Country>>> GetAllCountries(bool cities = false)
        {
            return await this._countryService.GetAllCountries(cities);
        }

        [HttpPost]
        [Route("country")]
        public async Task<ActionResult<Country>> AddCountry(Country countryToAdd)
        {
            return await this._countryService.AddCountry(countryToAdd);
        }

        [HttpGet]
        [Route("cities")]
        public async Task<ActionResult<List<City>>> GetAllCities(string country = "")
        {
            return await this._countryService.GetAllCities(country);
        }

        [HttpPost]
        [Route("city")]
        public async Task<ActionResult<City>> AddCity(City cityToAdd)
        {
            return await this._countryService.AddCity(cityToAdd);
        }
    }
}
