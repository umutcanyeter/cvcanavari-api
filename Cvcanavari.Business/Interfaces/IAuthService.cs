using System.Threading.Tasks;
using Cvcanavari.Entities.Concrete;
using Cvcanavari.Entities.Dtos;
using Cvcanavari.Utilities.Results;
using Cvcanavari.Utilities.Security.Jwt;

namespace Cvcanavari.Business.Interfaces
{
    public interface IAuthService
    {
        Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto);
        Task<IResult> UserExists(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user);
    }
}