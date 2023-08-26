using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    public static User user = new User();
    private readonly IConfiguration _configuration;

    public UsersController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserObject request)
    {
      var result = await Task.Run(() =>
      {
        var user = new User();
        CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

        user.Username = request.Username;
        user.PasswordHash = passwordHash;
        user.PasswordSalt = passwordSalt;

        return user;
      });

      return Ok(result);
    }


    [HttpPost("login")]
    public ActionResult<string> Login(UserObject userLoggingIn)
    {
      var user = new User();
      if (user.Username != userLoggingIn.Username)
      {
        return BadRequest("User not found.");
      }
      if (!VerifyPasswordHash(userLoggingIn.Password, user.PasswordHash, user.PasswordSalt))
      {
        return BadRequest("Wrong password.");
      }

      string token = CreateToken(user);
      return Ok(token);
    }

    private string CreateToken(User user)
    {
      List<Claim> claims = new List<Claim>
            {
            new Claim(ClaimTypes.Name, user.Username)
            };
      var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
      var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
      var token = new JwtSecurityToken(
          claims: claims,
          expires: DateTime.Now.AddDays(1),
          signingCredentials: creds);

      var jwt = new JwtSecurityTokenHandler().WriteToken(token);

      return jwt;
    }


    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
      using (var hmac = new HMACSHA512())
      {
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
      }
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
      using (var hmac = new HMACSHA512(passwordSalt))
      {
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
      }
    }
  }
}
