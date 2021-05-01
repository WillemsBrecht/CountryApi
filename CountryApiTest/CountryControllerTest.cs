using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using CountryApi.Models;

using FluentAssertions;

using Newtonsoft.Json;

using Xunit;

namespace CountryApiTest
{
    public class CountryControllerTest : IClassFixture<WebApplicationFactory<CountryApi.Startup>>
    {
        private HttpClient _client;

        public CountryControllerTest(WebApplicationFactory<CountryApi.Startup> client)
        {
            this._client = client.CreateClient();
        }

        [Fact]
        public async Task GetAllCities()
        {
            var response = await this._client.GetAsync("/api/cities");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(await response.Content.ReadAsStringAsync());
            Assert.True(cities.Count > 0);
        }

        [Theory]
        [InlineData("BE")]
        public async Task GetAllCitiesFromCountry(string ISOCode)
        {
            var response = await this._client.GetAsync("/api/cities?country="+ISOCode);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(await response.Content.ReadAsStringAsync());
            Assert.True(cities.Count > 0);
        }

        [Theory]
        [InlineData("MOON")]
        public async Task GetAllCitiesFromCountryThatDoesNotExist(string ISOCode)
        {
            var response = await this._client.GetAsync("/api/cities?country="+ISOCode);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<City> cities = JsonConvert.DeserializeObject<List<City>>(await response.Content.ReadAsStringAsync());
            Assert.True(cities.Count == 0);
        }

        [Fact]
        public async Task GetAllCountries()
        {
            var response = await this._client.GetAsync("/api/countries");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(await response.Content.ReadAsStringAsync());
            Assert.True(countries.Count > 0);
        }

        [Fact]
        public async Task GetAllUsers()
        {
            var response = await this._client.GetAsync("/api/users");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync());
            Assert.True(users.Count > 0);
        }

        [Fact]
        public async Task AddCountry()
        {
            Country countryToAdd = new Country()
            {
                ISOCode = "RU",
                Name = "Russia",
                Population = 316000000
            };
            
            string jsonCountry = JsonConvert.SerializeObject(countryToAdd);
            var response = await this._client.PostAsync("/api/country", new StringContent(jsonCountry, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task AddExisitingCountry()
        {
            Country countryToAdd = new Country()
            {
                ISOCode = "BE",
                Name = "Belgium",
                Population = 11000000
            };
            
            string jsonCountry = JsonConvert.SerializeObject(countryToAdd);
            var response = await this._client.PostAsync("/api/country", new StringContent(jsonCountry, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("Country already exists.", await response.Content.ReadAsStringAsync()));
        }

        [Fact]
        public async Task AddCity()
        {
            City cityToAdd = new City()
            {
                Name = "Inverness",
                Population = 1200000,
                CountryISOCode = "UK"
            };

            string jsonCity = JsonConvert.SerializeObject(cityToAdd);
            var response = await this._client.PostAsync("/api/city", new StringContent(jsonCity, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            cityToAdd = JsonConvert.DeserializeObject<City>(await response.Content.ReadAsStringAsync());
           Assert.False(cityToAdd.CityId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000000")));
        }

        [Fact]
        public async Task AddCityUnknownCountry()
        {
            City cityToAdd = new City()
            {
                Name = "MOON_BASE",
                Population = 12000000,
                CountryISOCode = "MOON"
            };

            string jsonCity = JsonConvert.SerializeObject(cityToAdd);
            var response = await this._client.PostAsync("/api/city", new StringContent(jsonCity, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("Country doesn't exist.", await response.Content.ReadAsStringAsync()));
        }

        [Fact]
        public async Task AddCityAlreadyExists()
        {
            City cityToAdd = new City()
            {
                Name = "Bruges",
                Population = 12000000,
                CountryISOCode = "BE"
            };

            string jsonCity = JsonConvert.SerializeObject(cityToAdd);
            var response = await this._client.PostAsync("/api/city", new StringContent(jsonCity, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("City already exist.", await response.Content.ReadAsStringAsync()));
        }

        [Fact]
        public async Task GetUserByUserNameNoUserName()
        {
            var response = await this._client.GetAsync("/api/user");
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }

        [Theory]
        [InlineData("Brechten")]
        public async Task GetUserByUserNameNoParams(string username)
        {
            User user;
            var response = await this._client.GetAsync("/api/user?username="+username);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            Assert.True(user != null);
        }

        [Theory]
        [InlineData("Brechten")]
        public async Task GetUserByUserNameCityParam(string username)
        {
            User user;
            var response = await this._client.GetAsync("/api/user?username="+username+"&cities=true");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            Assert.True(user != null && user.VisitedCountries == null && user.VisitedCities != null);
        }

        [Theory]
        [InlineData("Brechten")]
        public async Task GetUserByUserNameCountryParam(string username)
        {
            User user;
            var response = await this._client.GetAsync("/api/user?username="+username+"&countries=true");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            Assert.True(user != null && user.VisitedCountries != null && user.VisitedCities == null);
        }

        [Theory]
        [InlineData("Brechten")]
        public async Task GetUserByUserNameWithParams(string username)
        {
            User user;
            var response = await this._client.GetAsync("/api/user?username="+username+"&countries=true&cities=true");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            user = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            Assert.True(user != null && user.VisitedCountries != null && user.VisitedCities != null);
        }

        [Fact]
        public async Task AddUserVisitedCountryAlreadyVisited()
        {
            var response = await this._client.PostAsync("/api/visit/country?username=Brechten&ISOCode=BE", null);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("User has already visited this country", result));
        }

        [Fact]
        public async Task AddUserVisitedCountryUnkownUserAndCountry()
        {
            var response = await this._client.PostAsync("/api/visit/country?username=IMPOSSIBLE_USER_NAME&ISOCode=MOON", null);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("User or country doesn't exist", result));
        }

        [Theory]
        [InlineData("IMPOSSIBLE_USER_NAME")]
        public async Task GetUserByUserNameFail(string username)
        {
            var response = await this._client.GetAsync("/api/user?username="+username);
            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task AddExistingUser()
        {
            User userToAdd = new User()
            {

                UserName = "Brechten",
                FirstName = "Brecht",
                LastName = "Willems",
                Mail = "Brechtwillems@tt.com",
                VisitedCities = new List<UserCity>(),
                VisitedCountries = new List<UserCountry>()
            };

            string jsonUser = JsonConvert.SerializeObject(userToAdd);
            var response = await this._client.PostAsync("/api/user", new StringContent(jsonUser, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("User already exists", await response.Content.ReadAsStringAsync()));
        }

        [Fact]
        public async Task AddUserUnkownCity()
        {
            User userToAdd = new User()
            {

                UserName = "TEST",
                FirstName = "TEST",
                LastName = "TEST",
                Mail = "TEST@tt.com",
                VisitedCities = new List<UserCity>()
                {
                    new UserCity() { CityId = Guid.Parse("11111111-1111-1111-1111-111111111111") }
                },
                VisitedCountries = new List<UserCountry>()
            };

            string jsonUser = JsonConvert.SerializeObject(userToAdd);
            var response = await this._client.PostAsync("/api/user", new StringContent(jsonUser, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("City and/or country does not exist", result));
        }

        [Fact]
        public async Task AddUserUnkownCountry()
        {
            User userToAdd = new User()
            {

                UserName = "TEST",
                FirstName = "TEST",
                LastName = "TEST",
                Mail = "TEST@tt.com",
                VisitedCities = new List<UserCity>(),
                VisitedCountries = new List<UserCountry>()
                {
                    new UserCountry() { ISOCode = "MOON" }
                }
            };

            string jsonUser = JsonConvert.SerializeObject(userToAdd);
            var response = await this._client.PostAsync("/api/user", new StringContent(jsonUser, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("City and/or country does not exist", result));
        }

        [Fact]
        public async Task AddUpdateAndDeleteUser()
        {
            User userToAdd = new User()
            {

                UserName = "Test",
                FirstName = "Test",
                LastName = "Test",
                Mail = "Test@Test.test",
                VisitedCities = new List<UserCity>(),
                VisitedCountries = new List<UserCountry>()
            };

            // Add user
            userToAdd = await this.AddUser(userToAdd);
            Assert.False(userToAdd.UserId.Equals(Guid.Parse("00000000-0000-0000-0000-000000000000")));

            // Update user
            string oldMail = userToAdd.Mail;
            userToAdd.Mail = "Test2@Test.test";
            Assert.False(string.Equals(oldMail, await this.UpdateUser(userToAdd)));

            // Delete user
            Assert.True(await this.DeleteUser(userToAdd.UserId));
        }

        private async Task<string> UpdateUser(User userToUpdate)
        {
            User updatedUser;
            string updateJsonUser = JsonConvert.SerializeObject(userToUpdate);
            var updateResponse = await this._client.PutAsync("/api/user", new StringContent(updateJsonUser, Encoding.UTF8, "application/json"));
            updatedUser = JsonConvert.DeserializeObject<User>(await updateResponse.Content.ReadAsStringAsync());
            updateResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            return updatedUser.Mail;
        }

        private async Task<User> AddUser(User userToAdd)
        {
            string jsonUser = JsonConvert.SerializeObject(userToAdd);
            var response = await this._client.PostAsync("/api/user", new StringContent(jsonUser, Encoding.UTF8, "application/json"));
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            userToAdd = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            return userToAdd;
        }

        private async Task<bool> DeleteUser(Guid userId)
        {
            var deleteResponse = await this._client.DeleteAsync("/api/user?userId="+userId);
            deleteResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            return string.Equals("User has been removed", await deleteResponse.Content.ReadAsStringAsync());
        }

        [Theory]
        [InlineData("BE")]
        [InlineData("LUX")]
        public async Task GetUsersThatVisitCountry(string ISOCode)
        {
            var response = await this._client.GetAsync("/api/visit/country?country="+ISOCode);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync());
            Assert.True(users.Count > 0);
        }

        [Theory]
        [InlineData("d9fc3bca-9c0f-44b1-99be-0d8a5863a6ec")]
        [InlineData("dbba6527-4ff7-4aee-acc6-be8dac6ce333")]
        public async Task GetUsersThatVisitCity(Guid cityId)
        {
            var response = await this._client.GetAsync("/api/visit/city?cityId="+cityId);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync());
            Assert.True(users.Count > 0);
        }

        [Theory]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        public async Task GetUsersThatVisitUnknowCity(Guid cityId)
        {
            var response = await this._client.GetAsync("/api/visit/city?cityId="+cityId);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("City doesn't exist.", await response.Content.ReadAsStringAsync()));
        }

        [Theory]
        [InlineData("MOON")]
        public async Task GetUsersThatVisitsUnknowCountry(string ISOCode)
        {
            var response = await this._client.GetAsync("/api/visit/country?country="+ISOCode);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("Country doesn't exist.", await response.Content.ReadAsStringAsync()));
        }

        [Theory]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        public async Task DeleteUserThatDoesNotExist(Guid userId)
        {
            var response = await this._client.DeleteAsync("/api/user?userId="+userId);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            Assert.True(string.Equals("No user was found", await response.Content.ReadAsStringAsync()));
        }

        [Theory]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        public async Task AddUsersThatVisitsUnknowCity(Guid cityId)
        {
            var response = await this._client.PostAsync("/api/visit/city?username=Brechten&cityId="+cityId, null);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("User or city doesn't exist", result));
        }

        [Theory]
        [InlineData("d9fc3bca-9c0f-44b1-99be-0d8a5863a6ec")]
        public async Task AddUsersThatVisitsknowCity(Guid cityId)
        {
            var response = await this._client.PostAsync("/api/visit/city?username=brechten&cityId="+cityId, null);
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            string result = await response.Content.ReadAsStringAsync();
            Assert.True(string.Equals("User has already visited this city", result));
        }
    }
}
