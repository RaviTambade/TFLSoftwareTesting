using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


using MathLib;
using CatalogAPI.Controllers;
using ProductCatalog.Entities;

namespace TestProjectXUnitVijaySales
{
    public class UnitTestRemoteWebAPI
    {

        private readonly HttpClient _client;

        public UnitTestRemoteWebAPI() {
            // Initialize HttpClient with the base address of your web API
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5263/") };
        
        }

        [Fact]
        public async Task Get_ReturnsSuccessStatus()
        {
            // Arrange
            // Act
            var response = await _client.GetAsync("WeatherForecast");

            // Assert
            response.EnsureSuccessStatusCode(); // Throws exception if status code isn't success
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}