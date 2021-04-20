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
        Task<bool> CheckIfCityExists(City cityToCheck);
        Task<bool> CheckIfCountryExists(Country countryToCheck);
        Task<List<City>> GetAllCities(string countryToSearch);
        Task<List<Country>> GetAllCountries(bool showCities);
    }

    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;
        private readonly ICityRepository _cityRepo;

        public CountryService(ICountryRepository countryRepo, ICityRepository cityRepo)
        {
            _countryRepo = countryRepo;
            _cityRepo = cityRepo;
        }

        public async Task<List<Country>> GetAllCountries(bool showCities)
        {
            return await this._countryRepo.GetAllCountries(showCities);
        }

        public async Task<List<City>> GetAllCities(string countryToSearch)
        {
            return await this._cityRepo.GetAllCities(countryToSearch);
        }

        public async Task<Country> AddCountry(Country countryToAdd)
        {
            if (await this._countryRepo.CheckIfCountryExists(countryToAdd) == false)
            {
                return await this._countryRepo.AddCountry(countryToAdd);
            }
            else
            {
                return await this._countryRepo.GetCountryByISOCode(countryToAdd.ISOCode);
            }
        }

        public async Task<City> AddCity(City cityToAdd)
        {
            if (await this._cityRepo.CheckIfCityExists(cityToAdd) == false)
            {
                cityToAdd.CityId = Guid.NewGuid();
                return await this._cityRepo.AddCity(cityToAdd);
            }
            else
            {
                return await this._cityRepo.GetCityByName(cityToAdd.Name, cityToAdd.CountryISOCode);
            }
        }

        public async Task<bool> CheckIfCountryExists(Country countryToCheck)
        {
            return await this._countryRepo.CheckIfCountryExists(countryToCheck);
        }

        public async Task<bool> CheckIfCityExists(City cityToCheck)
        {
            return await this._cityRepo.CheckIfCityExists(cityToCheck);
        }
    }
}
