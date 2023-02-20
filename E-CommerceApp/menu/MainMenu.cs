using E_CommerceApp.enums;
using E_CommerceApp.implementations;
using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.menu
{
    public class MainMenu
    {
        IUserManager userManager = new UserManager();
        ICustomerManager customerManager = new CustomerManager();
        IManagerManager managerManager = new ManagerManager();
        IDeliveryManmanager deliveryManManager = new DeliveryManManager();
        ISuperAdminManager superAdminManager = new SuperAdminManager();
        CustomerMenu customerMenu = new CustomerMenu();
        SuperAdminMenu superAdminMenu = new SuperAdminMenu();

        public void RealMenu()
        {
            Console.WriteLine("welccome to CLH store\nenter 1 to sign up\nenter 2 to login");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                SignUpMenu();
            }
            else if(option == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("wrong input");
                RealMenu();
            }
        }

        public void SignUpMenu()
        {
            Console.Write("***SIGN UP***");
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your email: ");
            string email = Console.ReadLine();
            Console.Write("enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Console.Write("enter 1 for male, 2 for female: ");
            Gender gender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());
            Console.Write("enter your address: ");
            string address = Console.ReadLine();
            Console.Write("enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            userManager.RegisterUser(name, email, pin, gender, address, phoneNumber);
            customerManager.RegisterCustomer();
            RealMenu();
        }

        public void LoginMenu()
        {
            Console.WriteLine("***LOGIN***");
            Console.Write("enter your email: ");
            string email = Console.ReadLine();
            Console.Write("enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            var userlogin = userManager.Login(email, pin);
            if(userlogin == null)
            {
                Console.WriteLine("wrong cridentials");
                RealMenu();
            }
            else
            {
                Console.WriteLine("login successful");

                var superAdmin = superAdminManager.Get(userlogin.Email);
                var customer = customerManager.Get(userlogin.Email);
                var manager = managerManager.Get(userlogin.Email);
                var deliveryMan = deliveryManManager.Get(userlogin.Email);
                if(superAdmin != null)
                {
                    superAdminMenu.RealSuperAdminMenu();
                }
                else if(customer != null)
                {
                    customerMenu.RealCustomerMenu();
                }
                else if (manager != null)
                {

                }
                else if (deliveryMan != null)
                {

                }

                


                
            }

        }
    }
}