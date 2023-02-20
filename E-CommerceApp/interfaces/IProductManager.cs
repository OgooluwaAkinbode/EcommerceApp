using E_CommerceApp.enums;
using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface IProductManager
    {
        public void Addproduct(string productName, string serialNumber, double price, int quantity, ProductCategory category);
        public Product GetProduct(int id);
        public Product GetProduct(string productName);
        public void GetAllProducts();

    }
}