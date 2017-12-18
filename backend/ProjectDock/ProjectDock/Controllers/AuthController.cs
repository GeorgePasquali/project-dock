using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using ProjectDock.Models;

namespace ProjectDock.Controllers
{
    [Produces("application/json")]
    [Route("auth")]
    public class AuthController : Controller
    {

        public class JwtPacket
        {
            public string Token { get; set; }
        }

        [HttpPost("register")]
        public JwtPacket Register([FromBody]User user)
        {   
            // Create the raw json web token
            var jwt = new JwtSecurityToken();

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new JwtPacket()
            {
                Token = encodedJwt
            };
        }

    }
}