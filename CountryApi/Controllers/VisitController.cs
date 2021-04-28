using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Services;
using Microsoft.AspNetCore.Authorization;
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

        // [Authorize]
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
        public async Task<ActionResult> AddUser(User userToAdd)
        {
            User user = await this._userService.AddUser(userToAdd);
            if (user.UserId == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                return new BadRequestObjectResult("User already exists");
            }
            return new OkObjectResult(user);
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

        [HttpDelete]
        [Route("user")]
        public async Task<ActionResult<string>> DeletUser(Guid userId){
            bool result = await this._userService.DeleteUser(userId);
            if (result == false)
            {
                return new BadRequestObjectResult("No user was found");
            }
            return new OkObjectResult("User has been removed");
        }

        [HttpPost]
        [Route("visit/country")]
        public async Task<ActionResult<string>> AddCountryVisitToUser(string username, string ISOCode)
        {
            Result result = await this._userService.addUserVisitedCountry(username, ISOCode);
            if (result.Success == false)
            {
                return new BadRequestObjectResult(result.Message);
            }
            return new OkObjectResult(result.Message);
        }

        [HttpGet]
        [Route("visit/country")]
        public async Task<ActionResult<List<User>>> GetAllUsersThatVisitedCountry(string country)
        {
            return await this._userService.GetAllUsersThatVisitedCountry(country);
        }

        [HttpPost]
        [Route("visit/city")]
        public async Task<ActionResult<string>> AddCityVisitToUser(string username, Guid cityId)
        {
            Result result = await this._userService.addUserVisitedCity(username, cityId);
            if (result.Success == false)
            {
                return new BadRequestObjectResult(result.Message);
            }
            return new OkObjectResult(result.Message);
        }
    }
}
