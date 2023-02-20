using E_CommerceApp.enums;
using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class OrderManager : IOrderManager
    {
        public static List<Order> ordersDatabase = new List<Order>();
        public void CancelOrder(string refNumber)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Cancel;
                }
            }
        }

        public void GetAllOrders()
        {
            foreach (var order in ordersDatabase)
            {
                System.Console.WriteLine($"{order.CustomerEmail}\t{order.RefNumber}\t{order.Status}\t{order.TotalPrice}");
                foreach (var item in order.Products)
                {
                    System.Console.WriteLine($"{item.Key}\t{item.Value}");
                }
            }
        }

        public Order GetOrder(int id)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

        public Order GetOrder(string refNumber)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.RefNumber == refNumber)
                {
                    return order;
                }
            }
            return null;
        }

        public void MakeOrder(string customerEmail, double totalPrice, Dictionary<string, int> products)
        {
            Order order = new Order(ordersDatabase.Count + 1, GenerateReferenceNumber(), customerEmail, totalPrice, DeliveryStatus.Initiated, products);
            ordersDatabase.Add(order);
        }

        public void OrderDelivered(string refNumber)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Delivered;
                }
            }
        }

        public void OrderEnroute(string refNumber)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Enroute;
                }
            }
        }

        public void OrderReady(string refNumber)
        {
            foreach (var order in ordersDatabase)
            {
                if (order.RefNumber == refNumber)
                {
                    order.Status = DeliveryStatus.Ready;
                }
            }
        }

        private string GenerateReferenceNumber()
        {
            Random rand = new Random();
            return $"CLH/ODR/{rand.Next(1000, 9999)}";
        }

    }
}