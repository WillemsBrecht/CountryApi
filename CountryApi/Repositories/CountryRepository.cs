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
            if (showCities)
            {
                return await this._context.Countries.Include(country => country.Cities).ToListAsync();
            }
            else
            {
                return await this._context.Countries.ToListAsync();
            }
        }

        public async Task<List<City>> GetAllCities(string countryToSearch)
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
    }
}
