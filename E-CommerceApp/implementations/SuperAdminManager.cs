using E_CommerceApp.enums;
using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class SuperAdminManager : ISuperAdminManager
    {

        public static List<SuperAdmin> superAdminDatabase = new List<SuperAdmin>{
            new SuperAdmin(1, 1, "CLH/STF/001", "SuperAdmin"),
        };

        IUserManager userManager = new UserManager();
        public void UpdateProfile(string name, string email, Gender gender, string address, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public SuperAdmin Get(string email)
        {
            foreach (var superAdmin in superAdminDatabase)
            {
                var user = userManager.GetUser(email);
                if (superAdmin.UserId == user.Id)
                {
                    return superAdmin;
                }
            }
            return null;
        }
    }
}