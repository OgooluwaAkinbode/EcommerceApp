using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class DeliveryManManager : IDeliveryManmanager
    {
        public static List<DeliveryMan> deliveryMenDatabase = new List<DeliveryMan>();
        IUserManager userManager = new UserManager();
        public void GetAllDeliveryMen()
        {
            foreach (var deliveryMan in deliveryMenDatabase)
            {
                var user = userManager.GetUser(deliveryMan.UserId);
                System.Console.WriteLine($"{user.Name}\t{deliveryMan.PlateNumber}\t{user.Address}\t{user.PhoneNumber}");
            }
        }

        public DeliveryMan Get(string email)
        {
            foreach (var deliveryMan in deliveryMenDatabase)
            {
                var user = userManager.GetUser(email);
                if (deliveryMan.UserId == user.Id)
                {
                    return deliveryMan;
                }
            }
            return null;
        }

        public DeliveryMan GetDeliveryMan(int id)
        {
            foreach (var deliveryMan in deliveryMenDatabase)
            {
                if (deliveryMan.Id == id)
                {
                    return deliveryMan;
                }
            }
            return null;
        }

        public DeliveryMan GetDeliveryMan(string plateNumber)
        {
            foreach (var deliveryMan in deliveryMenDatabase)
            {
                if (deliveryMan.PlateNumber == plateNumber)
                {
                    return deliveryMan;
                }
            }
            return null;
        }

        public void RegisterDeliveryMan(string plateNumber)
        {
            var deliveryMan = new DeliveryMan(deliveryMenDatabase.Count + 1, UserManager.userDatabase.Count, plateNumber, "DeliveryMan");
            deliveryMenDatabase.Add(deliveryMan);

            var user = userManager.GetUser(deliveryMan.UserId);

            Console.WriteLine($"Congrats mr/mrs {user.Name}, your reg no is {deliveryMan.PlateNumber}");
        }
    }

}