using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Passionflower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost("token")]
        public IActionResult Token()
        {
            //string tokenString = "test";
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                var usernameAndPassenc = Encoding.UTF8.GetString(Convert.FromBase64String(credValue));//admin:pass
                var usernameAndPass = usernameAndPassenc.Split(":");

                if (usernameAndPass[0] == "Admin" && usernameAndPass[1] == "pass")
                {
                    var claimsdata = new[] { new Claim(ClaimTypes.Name, "username") };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asdadsadsasdadsasdasdadsads"));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                        issuer: "",
                        audience: "",
                        expires: DateTime.Now.AddMinutes(1),
                        claims: claimsdata,
                        signingCredentials: signInCred
                     );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    return Ok(tokenString); 
                }
            }
            return BadRequest("wrong request");
        }

    }
}