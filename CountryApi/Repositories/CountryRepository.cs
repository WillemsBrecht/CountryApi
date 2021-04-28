using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryApi.Context;
using CountryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryApi.Repositories
{
    public interface ICountryRepository
    {
        Task<Country> AddCountry(Country countryToAdd);
        Task<bool> CheckIfCountryExists(Country countrytoCheck);
        Task<List<Country>> GetAllCountries(bool showCities);
        Task<Country> GetCountryByISOCode(string ISOCode);
    }

    public class CountryRepository : ICountryRepository
    {
        private IVisitContext _context;

        public CountryRepository(IVisitContext context)
        {
            this._context = context;
        }

        public async Task<List<Country>> GetAllCountries(bool showCities)
        {
            try
            {
                if (showCities == true)
                {
                    return await this._context.Countries.Include(country => country.Cities).ToListAsync();
                }
                else
                {
                    return await this._context.Countries.ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Country> AddCountry(Country countryToAdd)
        {
            try
            {
                await this._context.Countries.AddAsync(countryToAdd);
                await this._context.SaveChangesAsync();
                return countryToAdd;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> CheckIfCountryExists(Country countrytoCheck)
        {
            try
            {
                return await this._context.Countries.Where(country => (country.ISOCode == countrytoCheck.ISOCode)).Include(country => country.Cities).AnyAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<Country> GetCountryByISOCode(string ISOCode)
        {
            try
            {
                return await this._context.Countries.Where(country => country.ISOCode == ISOCode).SingleOrDefaultAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
