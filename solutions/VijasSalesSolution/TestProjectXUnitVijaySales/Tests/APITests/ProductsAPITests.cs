using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json;

using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using ProductCatalog.Entities;
using HR.Entities;

namespace VijaySales.Tests.APITests
{
   

        public class ProductsAPITests 
        {
        

        
            private const string BaseUrl = "http://localhost:5222/products";
            private readonly HttpClient _httpClient;

            public ProductsAPITests()
            {
                _httpClient = new HttpClient();
            }


            [Fact]
            public async Task Get_ReturnsCorrectResponse()
            {
                // Arrange
                List<Product> expectedProducts = new List<Product>();
                expectedProducts.Add(new Product("Jasmine", "Smelling Flower", "flowers", 4500, 12));
                expectedProducts.Add(new Product("Tulip", "Delicate Flower", "flowers", 5400, 10));
                expectedProducts.Add(new Product("Marigold", "Festival Flower", "flowers", 45000, 1));
                expectedProducts.Add(new Product("Lotus", "Worship Flower", "flowers", 3400, 24));

                // Act
                var response = await _httpClient.GetAsync(BaseUrl);
                response.EnsureSuccessStatusCode();

         
                var content=await response.Content.ReadAsStringAsync();
                List<Product> resultProducts = JsonSerializer.Deserialize<List<Product>>(content);

                // Assert
               // Assert.NotNull(resultProducts);
                Assert.Equal(expectedProducts, resultProducts);
            }
        }
    }
 