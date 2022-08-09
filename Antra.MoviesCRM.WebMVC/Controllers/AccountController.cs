using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly IConfiguration configuration;
        public AccountController(IUserService userService, IConfiguration configuration)
        {
            this.userService = userService;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            var result = await userService.Login(model);
            if (!result.Succeeded)
                return View(model);

            // list of claims
            var authClaims = new List<Claim> {
                new Claim(ClaimTypes.Name, model.Email),
                new Claim(ClaimTypes.Country, "USA"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256Signature)
                );
            var t = new JwtSecurityTokenHandler().WriteToken(token);
            return Redirect("/");
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(UserSignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await userService.SignUp(model);
            if (result.Succeeded)
            {
                return Redirect("/");
            }
            StringBuilder sb = new();
            foreach (var item in result.Errors)
            {
                sb.Append(item.Description);
            }
            return View(model);

        }
    }
}
