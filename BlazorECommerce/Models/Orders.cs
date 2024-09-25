using System.ComponentModel.DataAnnotations;

namespace BlazorECommerce.Models;

public class Order(int OrderId, DateTime OrderDate)
{
    [Required] public int OrderId { get; set; } = OrderId;
    [Required] public DateTime OrderDate { get; set; } = OrderDate;
    [Required] public List<Products> Products { get; set; } = null!;
}