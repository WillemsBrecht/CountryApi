using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
            try
            {
                return await this._countryService.GetAllCountries(cities);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("country")]
        public async Task<ActionResult> AddCountry(Country countryToAdd)
        {
            try
            {
                CountryResult result = await this._countryService.AddCountry(countryToAdd);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }

                return new OkObjectResult(result.OneCountry);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("cities")]
        public async Task<ActionResult<List<City>>> GetAllCities(string country = "")
        {
            try
            {
                return await this._countryService.GetAllCities(country);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("city")]
        public async Task<ActionResult> AddCity(City cityToAdd)
        {
            try
            {
                CityResult result = await this._countryService.AddCity(cityToAdd);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }

                return new OkObjectResult(result.OneCity);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("user")]
        public async Task<ActionResult> AddUser(User userToAdd)
        {
            try
            {
                User user = await this._userService.AddUser(userToAdd);
                if (user.UserId == Guid.Parse("00000000-0000-0000-0000-000000000000"))
                {
                    return new BadRequestObjectResult("User already exists");
                }
                return new OkObjectResult(user);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            try
            {
                return await this._userService.GetAllUsers();   
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult<User>> GetUserByUsername(string username = "", bool countries = false, bool cities = false)
        {
            try
            {
                return await this._userService.GetUserByUsername(username, countries, cities);  
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        [Route("user")]
        public async Task<ActionResult<User>> UpdateUser(User userToUpdate)
        {
            try
            {
                UserResult result = await this._userService.UpdateUser(userToUpdate);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }

                return new OkObjectResult(result.OneUser);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete]
        [Route("user")]
        public async Task<ActionResult> DeletUser(Guid userId)
        {
            try
            {
                UserResult result = await this._userService.DeleteUser(userId);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }
                return new OkObjectResult(result.Message);   
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("visit/country")]
        public async Task<ActionResult<string>> AddCountryVisitToUser(string username, string ISOCode)
        {
            try
            {
                Result result = await this._userService.addUserVisitedCountry(username, ISOCode);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }
                return new OkObjectResult(result.Message);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("visit/country")]
        public async Task<ActionResult> GetAllUsersThatVisitedCountry(string country)
        {
            try
            {
                UserResult result = await this._userService.GetAllUsersThatVisitedCountry(country);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }
                return new OkObjectResult(result.userList);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [Route("visit/city")]
        public async Task<ActionResult<string>> AddCityVisitToUser(string username, Guid cityId)
        {
            try
            {
                Result result = await this._userService.addUserVisitedCity(username, cityId);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }
                return new OkObjectResult(result.Message);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("visit/city")]
        public async Task<ActionResult> GetAllUsersThatVisitedCity(Guid cityId)
        {
            try
            {
                UserResult result = await this._userService.GetAllUsersThatVisitedCity(cityId);
                if (result.Success == false)
                {
                    return new BadRequestObjectResult(result.Message);
                }
                return new OkObjectResult(result.userList);
            }
            catch (System.Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
