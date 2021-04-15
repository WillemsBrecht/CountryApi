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
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByUsername(string userName, bool showCountries);
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
                return await this._context.Users.Include(country => country.Visited).ToListAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserByUsername(string userName, bool showCountries)
        {
            try
            {
                if (showCountries)
                {
                    return await this._context.Users.Where(user => user.UserName.Equals(userName)).Include(user => user.Visited).SingleOrDefaultAsync();
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
    }
}
