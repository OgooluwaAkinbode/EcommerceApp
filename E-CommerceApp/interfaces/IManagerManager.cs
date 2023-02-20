using E_CommerceApp.models;

namespace E_CommerceApp.interfaces
{
    public interface IManagerManager
    {
        public void RegisterManager();
        public Manager GetManager(int id);
        public Manager GetManager(string staffRegNo);
        public Manager Get(string email);
        public void GetAllmanager();
    }
}