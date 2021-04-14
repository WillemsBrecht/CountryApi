using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryApi.Models;
using CountryApi.Repositories;

namespace CountryApi.Services
{
    public interface ICountryService
    {
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

    }
}
