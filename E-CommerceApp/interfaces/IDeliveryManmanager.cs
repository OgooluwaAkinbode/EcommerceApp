using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface IDeliveryManmanager
    {
        public void RegisterDeliveryMan(string plateNumber);
        public DeliveryMan GetDeliveryMan(int id);
        public DeliveryMan GetDeliveryMan(string plateNumber);
        public DeliveryMan Get(string email);
        public void GetAllDeliveryMen();

    }
}