using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCatalog.Entities;
using TestProjectXUnitVijaySales.Utility;
using HR.Entities;
using HR.Respositories;

namespace TestProjectXUnitVijaySales.BusinessObjectTests.cs
{
   public class HRTests
    {
        [Fact]
        public static void GetPeopleTest()
        {
            //Arrange
            DataManager dataAgent = new DataManager();
            List<Person> expectedPeople= dataAgent.GetJSONSampleData();
            
            //Act
            List<Person> actualPeople=HRManager.GetAllPeople();
           
            //Assert
            Assert.Equal(expectedPeople, actualPeople);
        }
    }
}
