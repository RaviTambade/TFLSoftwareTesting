using MathLib;
using CatalogAPI.Controllers;
using ProductCatalog.Entities;

namespace TestProjectXUnitVijaySales.Tests.ControllerTests
{
    public class FlowersControllerTests
    {

        [Fact]
        public async Task GetAsync_GetProduct()
        {
            //Arrange
            var controller = new FlowersController();
            int id = 45;
            Product expectedProduct = new Product("Jasmine", "Smelling Flower", "flowers", 4500, 12);

            //Act
            var actualProduct = await controller.GetByIdAsync(id);

            //Assert
            Assert.Equal(expectedProduct, actualProduct);
        }
    }
}