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
        private readonly IUserService _userService;

        public VisitController(ICountryService countryService, IUserService userService)
        {
            _countryService = countryService;
            _userService = userService;
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

        [HttpPost]
        [Route("user")]
        public async Task<ActionResult<User>> AddUser(User userToAdd)
        {
            return await this._userService.AddUser(userToAdd);
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await this._userService.GetAllUsers();
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult<User>> GetUserByUsername(string username, bool countries = false, bool cities = false)
        {
            return await this._userService.GetUserByUsername(username, countries, cities);
        }

        [HttpPut]
        [Route("user")]
        public async Task<ActionResult<User>> UpdateUser(User userToUpdate){
            return await this._userService.UpdateUser(userToUpdate);
        }

        [HttpPost]
        [Route("visit/country")]
        public async Task<ActionResult<string>> AddCountryVisitToUser(string username, string ISOCode)
        {
            return await this._userService.addUserVisitedCountry(username, ISOCode);
        }

        [HttpGet]
        [Route("visit/country")]
        public async Task<ActionResult<List<User>>> GetAllUsersThatVisitedCountry(string country)
        {
            return await this._userService.GetAllUsersThatVisitedCountry(country);
        }

        [HttpPost]
        [Route("visit/city")]
        public async Task<ActionResult<string>> AddCountryVisitToUser(string username, Guid cityId)
        {
            return await this._userService.addUserVisitedCity(username, cityId);
        }
    }
}
