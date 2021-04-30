using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryApi.Context;
using CountryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryApi.Repositories
{
    public interface ICityRepository
    {
        Task<City> AddCity(City cityToAdd);
        Task<List<City>> GetAllCities(string countryToSearch);
        Task<City> GetCityById(Guid cityId);
        Task<City> GetCityByName(string cityName, string ISOCode);
    }

    public class CityRepository : ICityRepository
    {
        private readonly IVisitContext _context;

        public CityRepository(IVisitContext context)
        {
            _context = context;
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

        public async Task<City> GetCityByName(string cityName, string ISOCode)
        {
            try
            {
                return await this._context.Cities.Where(city => (city.Name == cityName) && (city.CountryISOCode == ISOCode)).SingleOrDefaultAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }


        public async Task<City> GetCityById(Guid cityId)
        {
            try
            {
                return await this._context.Cities.Where(city => city.CityId == cityId).SingleOrDefaultAsync();
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
