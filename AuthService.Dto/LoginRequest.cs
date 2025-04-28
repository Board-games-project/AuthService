using System.ComponentModel.DataAnnotations;

namespace AuthService.Dto;

/// <summary>
/// Login information
/// </summary>
public readonly record struct LoginRequest
{
  /// <summary>
  /// User login.
  /// </summary>
  [Required]
  public string Login { get; init; }

  /// <summary>
  /// User password.
  /// </summary>
  [Required]
  public string Password { get; init; }
}
