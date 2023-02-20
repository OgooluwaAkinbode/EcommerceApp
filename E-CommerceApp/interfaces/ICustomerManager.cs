using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface ICustomerManager
    {
        public void RegisterCustomer();
        public Customer GetCustomer(int id);
        public Customer GetCustomer(string regNo);
        public Customer Get(string email);
        public void GetAllCustomer();


    }
}