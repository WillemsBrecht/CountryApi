using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryApi.Context;
using CountryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> AddUser(User userToAdd);
        Task<string> AddUserVisitedCity(User selectedUser, City cityToAdd);
        Task<string> AddUserVisitedCountry(User selectedUser, Country countryToAdd);
        Task<List<User>> GetAllUsers();
        Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode);
        Task<User> GetUserByUsername(string userName, bool showCountries = false, bool showCities = false);
        Task<User> UpdateUser(User userToUpdate);
    }

    public class UserRepository : IUserRepository
    {
        private IVisitContext _context;

        public UserRepository(IVisitContext context)
        {
            this._context = context;
        }

        public async Task<User> AddUser(User userToAdd)
        {
            try
            {
                await this._context.Users.AddAsync(userToAdd);
                await this._context.SaveChangesAsync();
                return userToAdd;
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
                return await this._context.Users.Include(country => country.VisitedCountries).Include(city => city.VisitedCities).ThenInclude(city => city.City).ToListAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserByUsername(string userName, bool showCountries = false, bool showCities = false)
        {
            try
            {
                if (showCountries && showCities)
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).Include(user => user.VisitedCountries).Include(user => user.VisitedCities).SingleOrDefaultAsync();
                }
                if (showCountries)
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).Include(user => user.VisitedCountries).SingleOrDefaultAsync();
                }
                if (showCities)
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).Include(user => user.VisitedCountries).Include(user => user.VisitedCities).SingleOrDefaultAsync();
                }
                return await this._context.Users.Where(user => user.UserName.Equals(userName)).SingleOrDefaultAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<string> AddUserVisitedCountry(User selectedUser, Country countryToAdd)
        {
            try
            {
                await this._context.UserCountries.AddAsync(new UserCountry() { UserId = selectedUser.UserId, ISOCode = countryToAdd.ISOCode });
                await this._context.SaveChangesAsync();
                return "Added country to user's visited list";
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode)
        {
            try
            {
                return await this._context.Users.Where(user => (user.VisitedCountries.Any(visited => visited.ISOCode.Equals(ISOCode)))).ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<string> AddUserVisitedCity(User selectedUser, City cityToAdd)
        {
            try
            {
                await this._context.UserCities.AddAsync(new UserCity() { UserId = selectedUser.UserId, CityId = cityToAdd.CityId });
                await this._context.SaveChangesAsync();
                return "Added city to user's visited list";
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<User> UpdateUser(User userToUpdate)
        {
            try
            {
                User user = this._context.Users.First(user => user.UserId == userToUpdate.UserId);
                user.FirstName = userToUpdate.FirstName;
                user.LastName = userToUpdate.LastName;
                user.Mail = userToUpdate.Mail;
                user.UserName = userToUpdate.UserName;
                await this._context.SaveChangesAsync();
                return await this.GetUserByUsername(userToUpdate.UserName);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
