using System.Threading;
using System.Collections.Immutable;
using System;
using CountryApi.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CountryApi.Models;
using System.Threading.Tasks;

namespace CountryApi.Context
{
    public interface IVisitContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<UserCountry> UserCountries { get; set; }
        DbSet<UserCity> UserCities { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken token = default);
    }

    public class VisitContext : DbContext, IVisitContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UserCountry> UserCountries { get; set; }
        public DbSet<UserCity> UserCities { get; set; }

        private Connectionstrings _connectionStrings;

        public VisitContext(DbContextOptions<VisitContext> options, IOptions<Connectionstrings> connectionStrings) : base(options)
        {
            this._connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserCountry>().HasKey(uc => new { uc.UserId, uc.ISOCode });
            builder.Entity<UserCity>().HasKey(uc => new { uc.UserId, uc.CityId });
            builder.Entity<Country>().HasMany(country => country.Cities).WithOne(city => city.Country);

            builder.Entity<Country>().HasData(
                new Country()
                {
                    ISOCode = "BE",
                    Name = "Belgium",
                    Population = 11629113
                },
                new Country()
                {
                    ISOCode = "LUX",
                    Name = "Luxembourg",
                    Population = 613894
                },
                new Country()
                {
                    ISOCode = "FR",
                    Name = "France",
                    Population = 65387226
                },
                new Country()
                {
                    ISOCode = "DE",
                    Name = "Germany",
                    Population = 83995211
                },
                new Country()
                {
                    ISOCode = "NL",
                    Name = "The Netherlands",
                    Population = 17164721
                }
            );

            builder.Entity<City>().HasData(
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Luxembourg City",
                    Population = 114303,
                    CountryISOCode = "LUX"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Echternach",
                    Population = 5614,
                    CountryISOCode = "LUX"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Bruges",
                    Population = 118656,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Ghent",
                    Population = 466000,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Antwerp",
                    Population = 523248,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Brussels",
                    Population = 2081000,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Liège",
                    Population = 195965,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Tournai",
                    Population = 69083,
                    CountryISOCode = "BE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Strasbourg",
                    Population = 272222,
                    CountryISOCode = "FR"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Paris",
                    Population = 11017000,
                    CountryISOCode = "FR"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Calais",
                    Population = 868277,
                    CountryISOCode = "FR"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Bordeaux",
                    Population = 257068,
                    CountryISOCode = "FR"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Rotterdam",
                    Population = 651446,
                    CountryISOCode = "NL"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Amsterdam",
                    Population = 1149000,
                    CountryISOCode = "NL"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Berlin",
                    Population = 3562000,
                    CountryISOCode = "DE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Frankfurt",
                    Population = 777000,
                    CountryISOCode = "DE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Hamburg",
                    Population = 1790000,
                    CountryISOCode = "DE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Munich",
                    Population = 1558395,
                    CountryISOCode = "DE"
                },
                new City()
                {
                    CityId = Guid.NewGuid(),
                    Name = "Trier",
                    Population = 111528,
                    CountryISOCode = "DE"
                }
            );
        }
    }
}
