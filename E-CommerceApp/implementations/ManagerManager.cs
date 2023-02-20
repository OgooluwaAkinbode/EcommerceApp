using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class ManagerManager : IManagerManager
    {
        public static List<Manager> managersDatabase = new List<Manager>();
        IUserManager userManager = new UserManager();

        public Manager Get(string email)
        {
            foreach (var manager in managersDatabase)
            {
                var user = userManager.GetUser(email);
                if (manager.UserId == user.Id)
                {
                    return manager;
                }
            }
            return null;
        }

        public void GetAllmanager()
        {
            foreach (var manager in managersDatabase)
            {
                var user = userManager.GetUser(manager.UserId);
                System.Console.WriteLine($"{user.Name}\t{manager.StaffRegNo}\t{user.Address}\t{user.PhoneNumber}");
            }
        }

        public Manager GetManager(int id)
        {
            foreach (var manager in managersDatabase)
            {
                if (manager.Id == id)
                {
                    return manager;
                }
            }
            return null;
        }

        public Manager GetManager(string staffRegNo)
        {
            foreach (var manager in managersDatabase)
            {
                if (manager.StaffRegNo == staffRegNo)
                {
                    return manager;
                }
            }
            return null;
        }

        public void RegisterManager()
        {
            var manager = new Manager(managersDatabase.Count + 1, UserManager.userDatabase.Count, GenerateStaffReg(),0, "Manager");
            managersDatabase.Add(manager);

            var user = userManager.GetUser(manager.UserId);

            Console.WriteLine($"Congrats mr/mrs {user.Name}, your reg no is {manager.StaffRegNo}");
        }

        private string GenerateStaffReg()
        {
            return "CLH/MGR/00" + (managersDatabase.Count + 1).ToString();
        }
    }
}