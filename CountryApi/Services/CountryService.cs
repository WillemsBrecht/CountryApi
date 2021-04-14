using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Repositories;

namespace CountryApi.Services
{
    public interface ICountryService
    {
        Task<City> AddCity(City cityToAdd);
        Task<Country> AddCountry(Country countryToAdd);
        Task<List<City>> GetAllCities(string countryToSearch);
        Task<List<Country>> GetAllCountries(bool showCities);
    }

    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;

        public CountryService(ICountryRepository countryRepository)
        {
            this._countryRepo = countryRepository;
        }

        public async Task<List<Country>> GetAllCountries(bool showCities)
        {
            return await this._countryRepo.GetAllCountries(showCities);
        }

        public async Task<List<City>> GetAllCities(string countryToSearch)
        {
            return await this._countryRepo.GetAllCities(countryToSearch);
        }

        public async Task<Country> AddCountry(Country countryToAdd)
        {
            return await this._countryRepo.AddCountry(countryToAdd);
        }

        public async Task<City> AddCity(City cityToAdd)
        {
            if (this._countryRepo.CheckIfCityExists(cityToAdd) == false)
            {
                cityToAdd.CityId = Guid.NewGuid();
                return await this._countryRepo.AddCity(cityToAdd);
            }
            else
            {
                return await this._countryRepo.GetCityByName(cityToAdd.Name, cityToAdd.CountryISOCode);
            }
        }

    }
}
