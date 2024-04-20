using ProductCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repositories
{
    public class ProductManager
    {
        public static List<Product> GetAll()
        {
            var products = new List<Product>();
            products.Add(new Product("Jasmine", "Smelling Flower", "flowers"));
            products.Add(new Product("Tulip", "Delicate Flower", "flowers"));
            products.Add(new Product("Marigold", "Festival Flower", "flowers"));
            products.Add(new Product("Lotus", "Worship Flower", "flowers"));
            return products;
        }

        public static Product GetById(int id)
        {
            //database code will take input as id 
            //that will search product with id 
            //product will be returned
            Product product=new Product("Rose", "Smelling Flower", "flowers");
            return product;
        }

        public static bool Insert(Product product)
        {
            List<Product> products = GetAll();
            products.Add(product);
            return true;

        }

        public static bool Update(Product product)
        {
            List<Product> products = GetAll();
            //products.Add(product);
            //logic to update exsting product from collection
            return true;

        }
        public static bool Delete(Product product)
        {
            List<Product> products = GetAll();
            //logic to remove product from collection
            return true;

        }
    }
}
