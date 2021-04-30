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
        Task<CityResult> AddCity(City cityToAdd);
        Task<CountryResult> AddCountry(Country countryToAdd);
        Task<bool> CheckIfCountryExists(string ISOCode);
        Task<List<City>> GetAllCities(string countryToSearch);
        Task<List<Country>> GetAllCountries(bool showCities);
        Task<City> GetCityById(Guid cityId);
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
            try
            {
                return await this._countryRepo.GetAllCountries(showCities);
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
                return await this._cityRepo.GetAllCities(countryToSearch);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<CountryResult> AddCountry(Country countryToAdd)
        {   
            try
            {
                CountryResult result;
                if (await this._countryRepo.CheckIfCountryExists(countryToAdd.ISOCode) == false)
                {
                    result = new CountryResult(true);
                    result.OneCountry = await this._countryRepo.AddCountry(countryToAdd);
                    return result;
                }

                result = new CountryResult(false, "Country already exists.");
                return result;
            }
            catch (System.Exception)
            {   
                throw;
            }
        }

        public async Task<CityResult> AddCity(City cityToAdd)
        {
            try
            {
                Country country = await this._countryRepo.GetCountryByISOCode(cityToAdd.CountryISOCode);
                bool countryExists = await this._countryRepo.CheckIfCountryExists(cityToAdd.CountryISOCode);
                City city = await this._cityRepo.GetCityByName(cityToAdd.Name, cityToAdd.CountryISOCode);

                CityResult result;

                if (countryExists == false)
                {
                    result = new CityResult(false, "Country doesn't exist.");
                    return result;
                }

                if (city == null && countryExists)
                {
                    result = new CityResult(true);
                    cityToAdd.CityId = Guid.NewGuid();
                    result.OneCity = await this._cityRepo.AddCity(cityToAdd);
                    return result;
                }

                result = new CityResult(false, "City already exist.");
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> CheckIfCountryExists(string ISOCode)
        {
            try
            {
                return await this._countryRepo.CheckIfCountryExists(ISOCode);
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
                return await this._cityRepo.GetCityById(cityId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}