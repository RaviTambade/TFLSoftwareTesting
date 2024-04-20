using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//What do you mean by namespace : (Package)
//it a collection of .net types


namespace ECommerceSenarios
{ 

    //Visibility of class
    //public, private, protected, internal---- Access specifiers
    public  class ProductCatalogScenario
    {

        //Unit Test
        // it is one kind of function of a class

        //Class:
        // consist of data members, member function or static members

        //Unit test function could be static or non Static

        [Fact]
        public static  void ProductTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public   void InventoryTest()
        {
            Assert.Equal(56, 1);

        }
    }

    public class ShoppingCartScenario
    {


        //Unit Test
        // it is one kind of function of a class


        //Class:
        // consist of data members, member function or static members

        //Unit test function could be static or non Static

        [Fact]
        public static void CartTest()
        {
            Assert.Equal(1, 1);

        }

        [Fact]
        public void ItemTest()
        {
            Assert.Equal(56, 1);

        }
    }
}
