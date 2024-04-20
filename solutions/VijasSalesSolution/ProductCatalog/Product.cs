namespace ProductCatalog.Entities
{
    public class Product:IComparable
    {
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Product()
        {
            Name = "gerbera";
            Description = "Wedding Flower";
            Category = "flowers";
        }
        public Product(string name, string description, string category)
        {
            Name = name;
            Description = description;
            Category = category;
        }

        public int CompareTo(object? obj)
        {
            Product secondObject= obj as Product;
            if (secondObject != null)
            {
                return secondObject.Name.CompareTo(Name);
            }
            else
            {
                return Name.CompareTo(Name);
            }
        }
    }
}
