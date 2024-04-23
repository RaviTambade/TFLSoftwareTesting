namespace ProductCatalog.Entities
{
    //Multi-Layer Application

    //UI layer
    //-----Web API
    //          Controllers ----DI
    //------------Service Layer
    //------------------Business Logic Layer
    //-----------------------Object Layer--Repository (DAL)
    //-------------------------------------------Data Layer (MySQL)

    //Object Layer Class (BOL)
    public class Product:IComparable
    {
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int StockAvailable { get; set; }
        public float UnitPrice {  get; set; }

        public Product()
        {
            Name = "gerbera";
            Description = "Wedding Flower";
            Category = "flowers";
        }
        public Product(string name, string description, string category, int stock, float unitPrice)
        {
            Name = name;
            Description = description;
            Category = category;
            StockAvailable = stock;
            UnitPrice = unitPrice;
        }

        public int CompareTo(object? obj)
        {
            Product secondObject= obj as Product;
            return secondObject.StockAvailable.CompareTo(StockAvailable);
        }
    }
}
