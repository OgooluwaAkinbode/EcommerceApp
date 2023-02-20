using E_CommerceApp.enums;
using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface ISuperAdminManager
    {
        public void UpdateProfile(string name, string email, Gender gender, string address, string phoneNumber);
        public SuperAdmin Get(string email);
    }
}