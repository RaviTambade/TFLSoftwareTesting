using MathLib;
using CatalogAPI.Controllers;
using ProductCatalog.Entities;

namespace TestProjectXUnitVijaySales.APIControllerTest
{
    public class ProductControllerTests
    {
        [Fact]
        public void GetProduct()
        {
            //Arrange
            var controller = new ProductsController();

            //Sample Data 
            Product expectedProduct = new Product("Rose", "Smelling Flower", "flowers");
            int id = 45;

            //Act
            var actualProduct = controller.GetById(45);

            //Assert
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void GetProducts()
        {
            //Arrange
            var controller = new ProductsController();


            //Sample Data 
            List<Product> expectedProducts = new List<Product>();
            expectedProducts.Add(new Product("Jasmine", "Smelling Flower", "flowers"));
            expectedProducts.Add(new Product("Tulip", "Delicate Flower", "flowers"));
            expectedProducts.Add(new Product("Marigold", "Festival Flower", "flowers"));
            expectedProducts.Add(new Product("Lotus", "Worship Flower", "flowers"));

            //Act
            var actualProducts = controller.GetAll();


            //Assert
            Assert.Equal(expectedProducts, actualProducts);
        }

        [Fact]
        public async Task GetAsync_GetProduct()
        {
            //Arrange
            var controller = new FlowersController();
            int id = 45;
            Product expectedProduct = new Product("Jasmine", "Smelling Flower", "flowers");

            //Act
            var actualProduct = await controller.GetByIdAsync(id);

            //Assert
            Assert.Equal(expectedProduct, actualProduct);
        }
    }
}