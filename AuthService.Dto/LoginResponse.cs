using System.ComponentModel.DataAnnotations;

namespace AuthService.Dto;

/// <summary>
/// Login result.
/// </summary>
public record LoginResponse
{
  /// <summary>
  /// User global unique identifier.
  /// </summary>
  [Required]
  public Guid UserId { get; init; }

  /// <summary>
  /// User access JWT.
  /// </summary>
  [Required]
  public string AccessToken { get; init; }

  /// <summary>
  /// User refresh JWT.
  /// </summary>
  [Required]
  public string RefreshToken { get; init; }

  /// <summary>
  /// AccessToken life time in minutes.
  /// </summary>
  [Required]
  public double AccessTokenExpiresIn { get; init; }

  /// <summary>
  /// RefreshToken life time in minutes.
  /// </summary>
  [Required]
  public double RefreshTokenExpiresIn { get; init; }
}
