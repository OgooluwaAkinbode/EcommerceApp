using E_CommerceApp.enums;

namespace E_CommerceApp.models
{
    public class Order
    {
        public int Id{ get; set; }
        public string RefNumber{ get; set; }
        public string CustomerEmail{ get; set; }
        public double TotalPrice{ get; set; }
        public DeliveryStatus Status{ get; set; }
        public Dictionary<string, int> Products { get; set; }

        public Order(int id, string refNumber, string customerEmail, double totalPrice, DeliveryStatus status, Dictionary<string, int> products)
        {
            Id = id;
            RefNumber = refNumber;
            CustomerEmail = customerEmail;
            TotalPrice = totalPrice;
            Status = status;
            Products = products;
        }
    }
}