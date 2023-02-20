using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> customerDatabase = new List<Customer>();
        IUserManager userManager = new UserManager();

        public Customer Get(string email)
        {
            foreach (var customer in customerDatabase)
            {
                var user = userManager.GetUser(email);
                if(customer.UserId == user.Id)
                {
                    return customer;
                }
            }
            return null;
        }

        public void GetAllCustomer()
        {
            foreach (var customer in customerDatabase)
            {
                var user = userManager.GetUser(customer.UserId);
                System.Console.WriteLine($"{user.Name}\t{customer.CustumerRegNo}\t{user.Address}\t{user.PhoneNumber}");
            }
        }

        public Customer GetCustomer(int id)
        {
            foreach (var customer in customerDatabase)
            {
                if(customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public Customer GetCustomer(string regNo)
        {
            foreach (var customer in customerDatabase)
            {
                if(customer.CustumerRegNo == regNo)
                {
                    return customer;
                }
            }
            return null;
        }

        public void RegisterCustomer()
        {
            var customer = new Customer(customerDatabase.Count + 1, UserManager.userDatabase.Count, GenerateCustomerReg(), 1000, "Customer");
            customerDatabase.Add(customer);

            var user = userManager.GetUser(customer.UserId);

            Console.WriteLine($"Congrats mr/mrs {user.Name}, your reg no is {customer.CustumerRegNo} and your wallet balance is {customer.Wallet}");

        }

        private string GenerateCustomerReg()
        {
            return "CLH/CTM/00" + (customerDatabase.Count + 1).ToString();
        }

    }
}