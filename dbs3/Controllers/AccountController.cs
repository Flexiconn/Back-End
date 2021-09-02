using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dbs3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {

        [HttpGet("register/{username}/{password}/{mail}")]
        public string RegisterUser(string username, string password, string mail)
        {
            return "username: " + username + " password: " + password + " mail: " + mail;
        }

        [HttpGet("login/{mail}/{password}")]
        public string LoginUser(string password, string mail)
        {
            return "password: " + password + " mail: " + mail;
        }

        [HttpGet("passwordReset/{mail}")]
        public string ResetPasswordUser(string mail)
        {
            return "mail: " + mail;
        }

        [HttpGet]
        public bool test()
        {
            return User.Identity.IsAuthenticated;
        }
    }
}
