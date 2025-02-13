using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PetGameAPI.Controllers
{
   [ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<Player> _userManager;
    private readonly SignInManager<Player> _signInManager;

    public AuthController(UserManager<Player> userManager, SignInManager<Player> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        var user = new Player { UserName = registerDto.Email, Email = registerDto.Email };
        var result = await _userManager.CreateAsync(user, registerDto.Password);
        if (result.Succeeded)
        {
            return Ok();
        }
        return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, false, false);
        if (result.Succeeded)
        {
            // Generate JWT token here and return it
            return Ok();
        }
        return Unauthorized();
    }
}
}
