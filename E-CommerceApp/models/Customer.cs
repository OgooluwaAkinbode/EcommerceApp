using E_CommerceApp.enums;

namespace E_CommerceApp.models
{
    public class Customer
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string CustumerRegNo { get; set; }
        public double Wallet{ get; set; }
        public string Role { get; set; }

        public Customer(int id, int userId, string customerRegNo, double wallet, string role)
        {
            Id = id;
            UserId = userId;
            CustumerRegNo = customerRegNo;
            Wallet = wallet;
            Role = role;
        }
    }
}