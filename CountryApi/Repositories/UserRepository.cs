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
        Task<string> addUserVisit(User selectedUser, Country countryToAdd);
        Task<List<User>> GetAllUsers();
        Task<List<User>> GetAllUsersThatVisitedCountry(string ISOCode);
        Task<User> GetUserByUsername(string userName, bool showCountries = false);
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
                return await this._context.Users.Include(country => country.VisitedCountries).ToListAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserByUsername(string userName, bool showCountries = false)
        {
            try
            {
                if (showCountries)
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).Include(user => user.VisitedCountries).SingleOrDefaultAsync();
                }
                else
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).SingleOrDefaultAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<string> addUserVisit(User selectedUser, Country countryToAdd)
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
            return await this._context.Users.Where(user => (user.VisitedCountries.Any(visited => visited.ISOCode.Equals(ISOCode)))).ToListAsync();
        }
    }
}
