using Cvcanavari.Entities.Abstract;

namespace Cvcanavari.Entities.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}