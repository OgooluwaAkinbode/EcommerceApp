using E_CommerceApp.enums;

namespace E_CommerceApp.models
{
    public class DeliveryMan
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string PlateNumber{ get; set; }
        public string Role { get; set; }

        public DeliveryMan(int id, int userId, string plateNumber,string role)
        {
            Id = id;
            UserId = userId;
            PlateNumber = plateNumber;
            Role = role;
        }
    }
}