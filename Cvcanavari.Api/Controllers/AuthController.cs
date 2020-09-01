using System.Threading.Tasks;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Cvcanavari.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private IUserService _userService;
        private IUserOperationClaimService _userOperationClaimService;

        public AuthController(IAuthService authService, IUserService userService, IUserOperationClaimService userOperationClaimService)
        {
            _authService = authService;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpPost("auth/register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = await _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
                return BadRequest(userExists.Message);
            var registerResult = await _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = await _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpPost("auth/login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = await _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
                return BadRequest(userToLogin.Message);
            var result = await _authService.CreateAccessToken(userToLogin.Data);
            if (!result.Success)
                return BadRequest(result.Message);
            return Ok(result.Data);
        }
    }
}