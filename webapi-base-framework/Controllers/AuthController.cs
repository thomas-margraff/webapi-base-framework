using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_base_framework.Models;

namespace webapi_base_framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // POST: api/Auth
        [HttpPost("login/")]
        public User Post(UserLogin userLogin)
        {
            int z = 2;
            return new User {
                UserName = userLogin.UserName,
                FirstName = "Tom",
                LastName = "Smith",
                Email = "tmargraff@gmail.com"
            };
        }
    }
}
