using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CountryApi.Services
{
    public interface IUserService
    {
        Task<User> AddUser(User userToAdd);
        Task<Result> addUserVisitedCity(string username, Guid cityId);
        Task<Result> addUserVisitedCountry(string username, string ISOCode);
        Task<bool> DeleteUser(Guid userId);
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
            if (await this._userRepo.CheckIfUserExists(userToAdd))
            {
                return userToAdd;
            }

            userToAdd.UserId = Guid.NewGuid();
            userToAdd.VisitedCountries = this.FillUserCountryList(userToAdd.VisitedCountries, userToAdd.UserId);
            userToAdd.VisitedCities = this.FillUserCityList(userToAdd.VisitedCities, userToAdd.UserId);
            return await this._userRepo.AddUser(userToAdd);
        }

        private List<UserCountry> FillUserCountryList(List<UserCountry> countryList, Guid userId)
        {
            List<UserCountry> countries = new List<UserCountry>();
            foreach (var country in countryList)
            {
                countries.Add(new UserCountry() { UserId = userId, ISOCode = country.ISOCode });
            }
            return countries;
        }

        private List<UserCity> FillUserCityList(List<UserCity> cityList, Guid userId)
        {
            List<UserCity> cities = new List<UserCity>();
            foreach (var city in cityList)
            {
                cities.Add(new UserCity() { UserId = userId, CityId = city.CityId });
            }
            return cities;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await this._userRepo.GetAllUsers();
        }

        public async Task<User> GetUserByUsername(string username, bool showCountries, bool showCities)
        {
            return await this._userRepo.GetUserByUsername(username, showCountries, showCities);
        }

        public async Task<Result> addUserVisitedCountry(string username, string ISOCode)
        {
            Country countryToCheck = new Country() { ISOCode = ISOCode };
            User userToCheck = await this._userRepo.GetUserByUsername(username, true, false);
            Result result = new Result();
            if ((await this._countryService.CheckIfCountryExists(countryToCheck) == false) || (await this._userRepo.CheckIfUserExists(userToCheck) == false))
            {
                result.Success = false;
                result.Message = "User or country doesn't exist";
                return result;
            }

            foreach (var visited in userToCheck.VisitedCountries)
            {
                if (visited.ISOCode == ISOCode)
                {
                    result.Success = false;
                    result.Message = "User has already visited this country";
                    return result;
                }
            }
            result.Success = true;
            result.Message = await this._userRepo.AddUserVisitedCountry(userToCheck, countryToCheck);
            return result;
        }

        public async Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode)
        {
            return await this._userRepo.GetAllUsersThatVisitedCountry(ISOCode);
        }

        public async Task<Result> addUserVisitedCity(string username, Guid cityId)
        {
            City cityToCheck = await this._countryService.GetCityById(cityId);
            User userToCheck = await this._userRepo.GetUserByUsername(username, false, true);
            Result result = new Result();

            if ((cityToCheck == null || await this._countryService.CheckIfCityExists(cityToCheck) == false) || (await this._userRepo.CheckIfUserExists(userToCheck) == false))
            {
                result.Success = false;
                result.Message = "User or city doesn't exist";
                return result;
            }

            foreach (var city in userToCheck.VisitedCities)
            {
                if (city.CityId == cityId)
                {
                    result.Success = false;
                    result.Message = "User has already visited this city";
                    return result;
                } 
            }
            result.Success = true;
            result.Message = await this._userRepo.AddUserVisitedCity(userToCheck, cityToCheck);
            return result;
        }

        public async Task<User> UpdateUser(User userToUpdate)
        {
            return await this._userRepo.UpdateUser(userToUpdate);
        }

        public async Task<bool> DeleteUser(Guid userId)
        {
            User userToDelete = await this._userRepo.GetUserById(userId);
            if (userToDelete == null)
            {
                return false;
            }
            return await this._userRepo.DeleteUser(userToDelete);
        }
    }
}
