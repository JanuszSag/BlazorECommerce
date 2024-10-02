using System.ComponentModel.DataAnnotations;

namespace BlazorECommerce.Models;

public class Orders
{
    [Key] public int IdOrder { get; set; }
    [Required] public DateTime OrderDate { get; set; }
    [Required] public List<Products> Products { get; set; } = null!;
    [Required] public virtual Users Users { get; set; } = null!;
}