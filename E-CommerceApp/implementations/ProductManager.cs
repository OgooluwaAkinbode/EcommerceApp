using E_CommerceApp.enums;
using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class ProductManager : IProductManager
    {
        public static List<Product> productsDatabase = new List<Product>();
        public void Addproduct(string productName, string serialNumber, double price, int quantity, ProductCategory category)
        {
            var productExists = CheckIfExists(productName);
            if(productExists != null)
            {
                productExists.Quantity += quantity;
            }
            else
            {
                var product = new Product(productsDatabase.Count + 1, productName, serialNumber, price, quantity, category);
                productsDatabase.Add(product);
                System.Console.WriteLine($"{product.ProductName} added successfully, quantity in stock is {product.Quantity}");
            }
        }

        public void GetAllProducts()
        {
            foreach (var product in productsDatabase)
            {
                System.Console.WriteLine($"{product.ProductName}\t{product.SerialNumber}\t{product.Quantity}");
            }
        }

        public Product GetProduct(int id)
        {
            foreach (var product in productsDatabase)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public Product GetProduct(string productName)
        {
            foreach (var product in productsDatabase)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }

        private Product CheckIfExists(string productName)
        {
            foreach (var product in productsDatabase)
            {
                if(product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }
    }
}