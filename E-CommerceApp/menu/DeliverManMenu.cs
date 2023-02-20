using E_CommerceApp.implementations;
using E_CommerceApp.interfaces;

namespace E_CommerceApp.menu
{
    public class DeliverManMenu
    {
        public void RealDeliverManMenu()
        {
            IProductManager productManager = new ProductManager();
            IOrderManager orderManager = new OrderManager();
            Console.WriteLine("enter 1 to view all ready order\nenter 2 to deliver order\\nenter 0 to go back");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                productManager.GetAllProducts();
                RealDeliverManMenu();
            }
            else if (option == 2)
            {
                
            }
            else if (option == 3)
            {

            }
            else if (option == 0)
            {
                //mainMenu.RealMenu();
            }
            else
            {
                System.Console.WriteLine("wrong input");
                RealDeliverManMenu();
            }
        }
    }
}