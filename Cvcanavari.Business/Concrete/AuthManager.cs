using System.Threading.Tasks;
using Cvcanavari.Business.Constants;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.Entities.Concrete;
using Cvcanavari.Entities.Dtos;
using Cvcanavari.Utilities.Results;
using Cvcanavari.Utilities.Security.Hashing;
using Cvcanavari.Utilities.Security.Jwt;

namespace Cvcanavari.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(ITokenHelper tokenHelper, IUserService userService)
        {
            _tokenHelper = tokenHelper;
            _userService = userService;
        }
        
        public async Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User()
            {
                Email = userForRegisterDto.Email,
                Name =  userForRegisterDto.Name,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            await _userService.Add(user);
            var userToReturn = await _userService.GetOneByFilter(u => u.Email == user.Email);
            return new SuccessDataResult<User>(userToReturn, Messages.UserRegistered);
        }

        public async Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = await _userService.GetOneByFilter(u => u.Email == userForLoginDto.Email);
            if (userToCheck == null)
                return new ErrorDataResult<User>(Messages.UserNotFound);
            if(!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash,userToCheck.PasswordSalt))
                return new ErrorDataResult<User>(Messages.PasswordError);
            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public async Task<IResult> UserExists(string email)
        {
            if (await _userService.GetOneByFilter(u => u.Email == email) != null)
                return new ErrorResult(Messages.UserAlreadyExists);
            return new SuccessResult();
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}