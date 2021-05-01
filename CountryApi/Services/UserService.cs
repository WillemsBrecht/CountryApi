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
        Task<UserResult> AddUser(User userToAdd);
        Task<Result> addUserVisitedCity(string username, Guid cityId);
        Task<Result> addUserVisitedCountry(string username, string ISOCode);
        Task<UserResult> DeleteUser(Guid userId);
        Task<List<User>> GetAllUsers();
        Task<UserResult> GetAllUsersThatVisitedCity(Guid cityId);
        Task<UserResult> GetAllUsersThatVisitedCountry(string ISOCode);
        Task<User> GetUserByUsername(string username, bool showCountries, bool showCities);
        Task<UserResult> UpdateUser(User userToUpdate);
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

        public async Task<UserResult> AddUser(User userToAdd)
        {
            try
            {
                UserResult result;
                if (await this._userRepo.CheckIfUserExists(userToAdd))
                {
                    result = new UserResult(false, "User already exists");
                    return result;
                }

                userToAdd.UserId = Guid.NewGuid();
                userToAdd.VisitedCountries = this.FillUserCountryList(userToAdd.VisitedCountries, userToAdd.UserId);
                userToAdd.VisitedCities = this.FillUserCityList(userToAdd.VisitedCities, userToAdd.UserId);

                if (await this.CheckUserCity(userToAdd.VisitedCities) == false || await this.CheckUserCountry(userToAdd.VisitedCountries) == false)
                {
                    result = new UserResult(false, "City and/or country do not exist");
                    return result;
                }
                result = new UserResult(true);
                result.OneUser = await this._userRepo.AddUser(userToAdd);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private async Task<bool> CheckUserCity(List<UserCity> userCities)
        {
            bool exists = true;
            foreach (UserCity city in userCities)
            {
                if (await this._countryService.GetCityById(city.CityId) == null)
                {
                    exists = false;
                }
            }
            return exists;
        }

        private async Task<bool> CheckUserCountry(List<UserCountry> userCountries)
        {
            bool exists = true;
            foreach (UserCountry country in userCountries)
            {
                if (await this._countryService.CheckIfCountryExists(country.ISOCode) == false)
                {
                    exists = false;
                }
            }
            return exists;
        }

        private List<UserCountry> FillUserCountryList(List<UserCountry> countryList, Guid userId)
        {
            try
            {
                List<UserCountry> countries = new List<UserCountry>();
                foreach (var country in countryList)
                {
                    countries.Add(new UserCountry() { UserId = userId, ISOCode = country.ISOCode });
                }
                return countries;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private List<UserCity> FillUserCityList(List<UserCity> cityList, Guid userId)
        {
            try
            {
                List<UserCity> cities = new List<UserCity>();
                foreach (var city in cityList)
                {
                    cities.Add(new UserCity() { UserId = userId, CityId = city.CityId });
                }
                return cities;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await this._userRepo.GetAllUsers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserByUsername(string username, bool showCountries, bool showCities)
        {
            try
            {
                return await this._userRepo.GetUserByUsername(username, showCountries, showCities);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Result> addUserVisitedCountry(string username, string ISOCode)
        {
            try
            {
                Country countryToCheck = new Country() { ISOCode = ISOCode };
                User userToCheck = await this._userRepo.GetUserByUsername(username, true, false);
                Result result = new Result();
                if ((await this._countryService.CheckIfCountryExists(countryToCheck.ISOCode) == false) || (await this._userRepo.CheckIfUserExists(userToCheck) == false))
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
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<UserResult> GetAllUsersThatVisitedCountry(string ISOCode)
        {
            try
            {
                UserResult result;
                bool test = await this._countryService.CheckIfCountryExists(ISOCode);
                if (test == false)
                {
                    result = new UserResult(false, "Country doesn't exist.");
                    return result;
                }

                result = new UserResult(true);
                result.userList = await this._userRepo.GetAllUsersThatVisitedCountry(ISOCode);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<UserResult> GetAllUsersThatVisitedCity(Guid cityId)
        {
            try
            {
                UserResult result;
                City city = await this._countryService.GetCityById(cityId);
                if (city == null)
                {
                    result = new UserResult(false, "City doesn't exist.");
                    return result;
                }

                result = new UserResult(true);
                result.userList = await this._userRepo.GetAllUsersThatVisitedCity(city.CityId);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Result> addUserVisitedCity(string username, Guid cityId)
        {
            try
            {
                City cityToCheck = await this._countryService.GetCityById(cityId);
                User userToCheck = await this._userRepo.GetUserByUsername(username, false, true);
                Result result = new Result();

                if ((cityToCheck == null) || (await this._userRepo.CheckIfUserExists(userToCheck) == false))
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
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<UserResult> UpdateUser(User userToUpdate)
        {
            try
            {
                UserResult result;
                if (await this._userRepo.GetUserById(userToUpdate.UserId) != null)
                {
                    result = new UserResult(true);
                    result.OneUser = await this._userRepo.UpdateUser(userToUpdate);
                    return result;
                }
                result = new UserResult(false, "User doesn't exist");
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<UserResult> DeleteUser(Guid userId)
        {
            try
            {
                UserResult result;
                User userToDelete = await this._userRepo.GetUserById(userId);
                if (userToDelete == null)
                {
                    result = new UserResult(false, "No user was found");
                    return result;
                }
                result = new UserResult(true, await this._userRepo.DeleteUser(userToDelete));
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
