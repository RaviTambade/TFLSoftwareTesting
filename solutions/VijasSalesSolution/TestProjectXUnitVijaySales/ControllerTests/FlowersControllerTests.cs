using MathLib;
using CatalogAPI.Controllers;
using ProductCatalog.Entities;

namespace TestProjectXUnitVijaySales.APIControllerTest
{
    public class FlowersControllerTests
    {
           
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