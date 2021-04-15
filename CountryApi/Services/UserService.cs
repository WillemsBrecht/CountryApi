using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Repositories;

namespace CountryApi.Services
{
    public interface IUserService
    {
        Task<string> addCountryVisitToUser(string userName, string ISOCode);
        Task<User> AddUser(User userToAdd);
        Task<List<User>> GetAllUsers();
        Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode);
        Task<User> GetUserByUsername(string username, bool showCountries);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly ICountryService _countryRepo;

        public UserService(IUserRepository userRepo, ICountryService countryRepo)
        {
            _userRepo = userRepo;
            _countryRepo = countryRepo;
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

        public async Task<User> GetUserByUsername(string username, bool showCountries)
        {
            return await this._userRepo.GetUserByUsername(username, showCountries);
        }

        public async Task<string> addCountryVisitToUser(string userName, string ISOCode)
        {
            Country countryToCheck = new Country() { ISOCode = ISOCode };
            User userToCheck = await this._userRepo.GetUserByUsername(userName, true);
            if ((await this._countryRepo.checkIfCountryExists(countryToCheck) == false) || (userToCheck == null))
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

            return await this._userRepo.addUserVisit(userToCheck, countryToCheck);
        }

        public async Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode)
        {
            return await this._userRepo.GetAllUsersThatVisitedCountry(ISOCode);
        }
    }
}
