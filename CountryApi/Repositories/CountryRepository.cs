using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryApi.Context;
using CountryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApi.Repositories
{
    public interface ICountryRepository
    {
        Task<City> AddCity(City cityToAdd);
        Task<Country> AddCountry(Country countryToAdd);
        Task<List<City>> GetAllCities(string countryToSearch);
        Task<List<Country>> GetAllCountries(bool showCities);
    }

    public class CountryRepository : ICountryRepository
    {
        private IVisitContext _context;

        public CountryRepository(IVisitContext context)
        {
            _context = context;
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

        public async Task<List<City>> GetAllCities(string countryToSearch)
        {
            try
            {
                if (countryToSearch.Equals(""))
                {
                    return await this._context.Cities.ToListAsync();
                }
                else
                {
                    return await this._context.Cities.Where(city => city.CountryISOCode.Equals(countryToSearch)).ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<City> AddCity(City cityToAdd)
        {
            try
            {
                await this._context.Cities.AddAsync(cityToAdd);
                await this._context.SaveChangesAsync();
                return cityToAdd;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
