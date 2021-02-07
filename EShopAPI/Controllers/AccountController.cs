using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using EShopAPI.ViewModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EShopAPI.Controllers
{
    //for Angular
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUp signUp)
        {
            var user = new IdentityUser() { Email = signUp.UserEmail, UserName = signUp.UserName  };
            var result = await _userManager.CreateAsync(user, signUp.UserPassword);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _signInManager.SignInAsync(user, isPersistent : false);

            return Ok(CreateToken(user));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.UserEmail, login.UserPassword, false,  false);
            if (!result.Succeeded)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByNameAsync(login.UserEmail);
            return Ok(CreateToken(user));
        }


        string CreateToken(IdentityUser user)
        {
            var claims = new Claim[]
                 {
                   new Claim(JwtRegisteredClaimNames.Sub, user.Id)
                 };

            var signingkey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("This is secret key"));
            var signingCredentials = new SigningCredentials(signingkey, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(signingCredentials: signingCredentials, claims: claims);
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

    }
}