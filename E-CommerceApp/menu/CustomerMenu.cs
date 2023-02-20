using E_CommerceApp.implementations;
using E_CommerceApp.interfaces;

namespace E_CommerceApp.menu
{
    public class CustomerMenu
    {
        IProductManager productManager = new ProductManager();
        IOrderManager orderManager = new OrderManager();
        //MainMenu mainMenu = new MainMenu();
        public void RealCustomerMenu()
        {
            Console.WriteLine("enter 1 to view all products\nenter 2 to make order\nenter 3 to fund wallet\nenter 0 to go back");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                productManager.GetAllProducts();
                RealCustomerMenu();
            }
            else if(option == 2)
            {
                MakeOrderMenu();
            }
            else if(option == 3)
            {

            }
            else if(option == 0)
            {
                //mainMenu.RealMenu();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                RealCustomerMenu();
            }
        }

        public void MakeOrderMenu()
        {

        }
    }
}