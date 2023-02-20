using E_CommerceApp.enums;
using E_CommerceApp.implementations;
using E_CommerceApp.interfaces;

namespace E_CommerceApp.menu
{
    public class SuperAdminMenu 
    {
        public void RealSuperAdminMenu()
        {
            IProductManager productManager = new ProductManager();
            IOrderManager orderManager = new OrderManager();
            Console.WriteLine("enter 1 to view all customers\nenter 0 to go back");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                productManager.GetAllProducts();
                RealSuperAdminMenu();
            }
            else if (option == 2)
            {

            }
            else if (option == 3)
            {

            }
            else if (option == 0)
            {
                mainMenu.RealMenu();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                RealSuperAdminMenu();
            }
        }
    }
}