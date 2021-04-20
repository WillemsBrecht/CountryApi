using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Repositories;

namespace CountryApi.Services
{
    public interface IUserService
    {
        Task<User> AddUser(User userToAdd);
        Task<string> addUserVisitedCity(string username, Guid cityId);
        Task<string> addUserVisitedCountry(string username, string ISOCode);
        Task<List<User>> GetAllUsers();
        Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode);
        Task<User> GetUserByUsername(string username, bool showCountries, bool showCities);
        Task<User> UpdateUser(User userToUpdate);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly ICountryService _countryService;

        public UserService(IUserRepository userRepo, ICountryService countryService)
        {
            _userRepo = userRepo;
            _countryService = countryService;
        }

        public async Task<User> AddUser(User userToAdd)
        {
            userToAdd.UserId = Guid.NewGuid();
            List<UserCountry> countries = new List<UserCountry>();
            foreach (var country in userToAdd.VisitedCountries)
            {
                countries.Add(new UserCountry() { UserId = userToAdd.UserId, ISOCode = country.ISOCode });
            }
            userToAdd.VisitedCountries = countries;
            return await this._userRepo.AddUser(userToAdd);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await this._userRepo.GetAllUsers();
        }

        public async Task<User> GetUserByUsername(string username, bool showCountries, bool showCities)
        {
            return await this._userRepo.GetUserByUsername(username, showCountries, showCities);
        }

        public async Task<string> addUserVisitedCountry(string username, string ISOCode)
        {
            Country countryToCheck = new Country() { ISOCode = ISOCode };
            User userToCheck = await this._userRepo.GetUserByUsername(username, true, false);
            if ((await this._countryService.CheckIfCountryExists(countryToCheck) == false) || (userToCheck == null))
            {
                return "User or country doesn't exist";
            }

            foreach (var visited in userToCheck.VisitedCountries)
            {
                if (visited.ISOCode == ISOCode)
                {
                    return "User has already visited this country";
                }
            }

            return await this._userRepo.AddUserVisitedCountry(userToCheck, countryToCheck);
        }

        public async Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode)
        {
            return await this._userRepo.GetAllUsersThatVisitedCountry(ISOCode);
        }

        public async Task<String> addUserVisitedCity(string username, Guid cityId)
        {
            City cityToCheck = new City() { CityId = cityId };
            User userToCheck = await this._userRepo.GetUserByUsername(username, false, true);

            if (await this._countryService.CheckIfCityExists(cityToCheck) == false && userToCheck == null)
            {
                return "User or city doesn't exist";
            }

            foreach (var city in userToCheck.VisitedCities)
            {
                if (city.CityId == cityId)
                {
                    return "User has already visited this city";
                }
            }

            return await this._userRepo.AddUserVisitedCity(userToCheck, cityToCheck);
        }

        public async Task<User> UpdateUser(User userToUpdate)
        {
            return await this._userRepo.UpdateUser(userToUpdate);
        }
    }
}
