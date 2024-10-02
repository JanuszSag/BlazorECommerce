using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorECommerce.Models;

public class Users
{
    [Key] public int UserId { get; set; }
    [Required] [MaxLength(100)] public string Username { get; set; }
    [Required] [EmailAddress] public string Email { get; set; }
    [Required] public byte[] PasswordHash { get; set; } 
    [Required] public byte[] PasswordSalt { get; set; }
    public virtual List<Orders> Orders { get; set; } = null!;
    [Required] [DefaultValue(false)] public bool IsAdmin { get; set; }
    [Required] [DefaultValue(true)] public bool IsActive { get; set; }
}