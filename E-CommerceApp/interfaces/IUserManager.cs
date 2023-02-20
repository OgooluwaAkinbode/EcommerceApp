using E_CommerceApp.enums;
using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface IUserManager
    {
        public User RegisterUser(string name, string email, int pin, Gender gender, string address, string phoneNumber);
        public User Login(string email, int pin);
        public User GetUser(int id);
        public User GetUser(string email);
    }
}