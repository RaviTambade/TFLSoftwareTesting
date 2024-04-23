using MathLib;
using ProductCatalog.Entities;
using ProductCatalog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectXUnitVijaySales.Tests.BusinessLogicTests
{
    public class ProductManagerTests
    {
        [Fact]
        public void GetAllProductsByProductManagerTest()
        {
            //Arrange

            List<Product> expectedProducts = new List<Product>();
            expectedProducts.Add(new Product("Jasmine", "Smelling Flower", "flowers", 4500, 12));
            expectedProducts.Add(new Product("Tulip", "Delicate Flower", "flowers", 5400, 10));
            expectedProducts.Add(new Product("Marigold", "Festival Flower", "flowers", 45000, 1));
            expectedProducts.Add(new Product("Lotus", "Worship Flower", "flowers", 3400, 24));

            //Act
            List<Product> actualProducts = ProductManager.GetAll();

            //Assert
            Assert.Equal(expectedProducts, actualProducts);
        }

    }
}
