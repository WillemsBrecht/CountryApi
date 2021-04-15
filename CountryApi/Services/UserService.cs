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
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByUsername(string username, bool showCities);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> AddUser(User userToAdd)
        {
            userToAdd.UserId = Guid.NewGuid();
            List<UserCountry> countries = new List<UserCountry>();
            foreach (var country in userToAdd.Visited)
            {
                countries.Add(new UserCountry() { UserId = userToAdd.UserId, ISOCode = country.ISOCode });
            }
            userToAdd.Visited = countries;
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
    }
}
