using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorECommerce.Models;

public class Categories
{
    [Key] public int IdCategory { get; set; }
    [Required] [MaxLength(100)] public string CategoryName { get; set; } = null!;
    public ICollection<Products>? Products { get; set; } = null!;
}