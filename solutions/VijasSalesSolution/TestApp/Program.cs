using ProductCatalog.Entities;
using System.Net.Http;
using System.Text.Json;

// Arrange
List<Product> expectedProducts = new List<Product>();
expectedProducts.Add(new Product("Jasmine", "Smelling Flower", "flowers", 4500, 12));
expectedProducts.Add(new Product("Tulip", "Delicate Flower", "flowers", 5400, 10));
expectedProducts.Add(new Product("Marigold", "Festival Flower", "flowers", 45000, 1));
expectedProducts.Add(new Product("Lotus", "Worship Flower", "flowers", 3400, 24));

// Act
HttpClient _client;
HttpClient _httpClient = new HttpClient();
string BaseUrl = "http://localhost:5222/products/";

var response = await _httpClient.GetAsync(BaseUrl);
response.EnsureSuccessStatusCode();

var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);
List<Product> resultProducts = JsonSerializer.Deserialize<List<Product>>(content);
foreach( Product p in resultProducts)
{
    Console.WriteLine(p.Name+ " "+ p.Description+ " "+ p.StockAvailable+ " "+ p.UnitPrice);   
}
