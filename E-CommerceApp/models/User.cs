namespace E_CommerceApp.models;
using E_CommerceApp.enums;
    
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Pin { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    

    public User(int id, string name, string email, int pin, Gender gender, string address, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        Pin = pin;
        Gender = gender;
        Address = address;
        PhoneNumber = phoneNumber;
    }
}
