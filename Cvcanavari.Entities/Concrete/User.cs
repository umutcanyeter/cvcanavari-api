using Cvcanavari.Entities.Abstract;

namespace Cvcanavari.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // If user is a company, name = company name. Or an employee, name = fullname.
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}