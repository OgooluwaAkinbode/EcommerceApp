using E_CommerceApp.enums;
using E_CommerceApp.interfaces;
using E_CommerceApp.models;

namespace E_CommerceApp.implementations
{
    public class UserManager : IUserManager
    {
        public static List<User> userDatabase = new List<User>{
            new User(1,"Prosper","prosper@gmail.com",1234,Gender.male,"abk","08136352827"),
        };

        public User GetUser(int id)
        {
            foreach (var user in userDatabase)
            {
                if(user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetUser(string email)
        {
            foreach (var user in userDatabase)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public User Login(string email, int pin)
        {
            foreach (var user in userDatabase)
            {
                if(user.Email == email && user.Pin == pin)
                {
                    return user;
                }
            }
            return null;
        }

        public User RegisterUser(string name, string email, int pin, Gender gender, string address, string phoneNumber)
        {
            var userExists = CheckIfExists(email);
            if(userExists != null)
            {
                System.Console.WriteLine("user already exist");
                return null;
            }
            else
            {
                var user = new User(userDatabase.Count + 1, name, email, pin, gender, address, phoneNumber);
                userDatabase.Add(user);
                return user;

            }
        }

        private User CheckIfExists(string email)
        {
            foreach (var user in userDatabase)
            {
                if(user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}