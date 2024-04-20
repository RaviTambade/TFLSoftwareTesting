using System.Net;
using System.Net.Http.Headers;

namespace VijaySales.Tests
{
    public class OrdersAPITests
    {
        private readonly HttpClient _client;

        public OrdersAPITests() {
            // Initialize HttpClient with the base address of your web API
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5295/") };
        }

        [Fact]
        public async Task Get_ReturnsSuccessStatusForAbhayUser()
        {
            // Arrange
            //This token is for user Abhay
             
            string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJjb250YWN0TnVtYmVyIjoiODQ1NjEyMzY1NCIsIm5hbWVpZCI6IjEiLCJ1bmlxdWVfbmFtZSI6IkFiaGF5TmF2YWxlIiwicm9sZSI6IkRpcmVjdG9yIiwibmJmIjoxNzEzNjA4OTYzLCJleHAiOjE3MTM2OTUzNjMsImlhdCI6MTcxMzYwODk2M30.j3dqfokzlue0z1nK-C7j4Zahvfj1Siov_ru02XB3yO0";
            //string token = "invalid token";
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act
            
            var response = await _client.GetAsync("api/orders");

            // Assert
            
            response.EnsureSuccessStatusCode(); // Throws exception if status code isn't success
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        [Fact]
        public async Task Get_ReturnsSuccessStatusForPragatiUser()
        {
            // Arrange
            //This token is for user Pragati
            //string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJjb250YWN0TnVtYmVyIjoiNzQ5ODAzNTY5MiIsIm5hbWVpZCI6IjEyIiwidW5pcXVlX25hbWUiOiJQcmdhdGlCYW5nZXIiLCJyb2xlIjoiRW1wbG95ZWUiLCJuYmYiOjE3MTM2MDgyMzIsImV4cCI6MTcxMzY5NDYzMiwiaWF0IjoxNzEzNjA4MjMyfQ.6N6hF7Rnvc-knL4oCsG5rKAz_BYHsAYDXd23xASNSEo";
            string token = "invalid token";
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Act

            var response = await _client.GetAsync("api/orders");

            // Assert

            response.EnsureSuccessStatusCode(); // Throws exception if status code isn't success
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}