using CleanArchitecture.API.Dto;
using CleanArchitecture.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _accountUser;

        public AccountsController(IUserService accountUser)
        {
            _accountUser = accountUser;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginReqDto loginReq)
        {
            var loginResp = await _accountUser.Authenticate(loginReq.userName!, loginReq.password!);

            return Ok(loginResp);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(LoginReqDto loginReq)
        {
            if (string.IsNullOrEmpty(loginReq.userName!) || string.IsNullOrEmpty(loginReq.password!))
            {
                return BadRequest("UserName or password cannot be empty.");
            }

            if (await _accountUser.UserAlreadyExists(loginReq.userName!))
            {
                return BadRequest("User already exists, please try different User Name.");
            }

            await _accountUser.Register(loginReq.userName!, loginReq.password!);

            return Ok();
        }
    }
}
