using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace BlazorECommerce.Models;

public class Products
{
    [Key] public int IdProduct { get; set; }
    [Required] public string ProductName { get; set; }
    [Required] public string ProductDescription { get; set; }
    [Required] public int ProductCategoryId { get; set; }
    [Required] public double ProductPrice { get; set; }
    [DefaultValue("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=")]public string ProductIcon { get; set; }
    [Required] public bool IsActive { get; set; }
    [Required] public List<Orders> Orders { get; set; } =  null!;
    [NotMapped] public Categories ProductCategories = null!;
}