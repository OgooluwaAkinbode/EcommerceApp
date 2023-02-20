using E_CommerceApp.enums;

namespace E_CommerceApp.models
{
    public class Product
    {
        public int Id{ get; set; }
        public string ProductName{ get; set; }
        public string SerialNumber{ get; set; }
        public double Price{ get; set; }
        public int Quantity{ get; set; }
        public ProductCategory Category{ get; set; }

        public Product(int id, string productName, string serialNumber, double price, int quantity, ProductCategory category)
        {
            Id = id;
            ProductName = productName;
            SerialNumber = serialNumber;
            Price = price;
            Quantity = quantity;
            Category = category;
        }

    }
}