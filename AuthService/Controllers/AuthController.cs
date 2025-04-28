using AuthService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers;

[ApiController]
[Route("auth")]
[Produces("")]
[Consumes("")]
public class AuthController
{
  [HttpPost("login")]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status404NotFound)]
  public Task<IActionResult> LoginAsync(
    [FromBody] LoginRequest request,
    [FromServices] ILoginCommand command)
  {
    return command.ExecuteAsync(request);
  }

  [HttpPost("refresh")]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status404NotFound)]
  public IActionResult RefreshAsync(
    [FromBody] string refreshToken,
    [FromServices] IRefreshCommand command)
  {
    return command.ExecuteAsync(request);
  }
}
