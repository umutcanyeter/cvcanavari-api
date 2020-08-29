using Cvcanavari.Entities.Abstract;

namespace Cvcanavari.Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}