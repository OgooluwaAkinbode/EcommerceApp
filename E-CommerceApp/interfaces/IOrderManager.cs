using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface IOrderManager
    {
        public void MakeOrder(string customerEmail, double totalPrice, Dictionary<string, int> products);
        public Order GetOrder(int id);
        public Order GetOrder(string refNumber);
        public void GetAllOrders();
        public void OrderReady(string refNumber);
        public void OrderEnroute(string refNumber);
        public void OrderDelivered(string refNumber);
        public void CancelOrder(string refNumber);

    }
}