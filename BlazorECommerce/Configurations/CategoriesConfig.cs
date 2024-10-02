using BlazorECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorECommerce.Configurations;

public class CategoriesConfig : IEntityTypeConfiguration<Categories>
{
    public void Configure(EntityTypeBuilder<Categories> builder)
    {
        builder.HasKey(x => x.IdCategory);
        builder.Property(x => x.IdCategory).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(100);

        builder.HasMany(x => x.Products)
               .WithOne(x => x.ProductCategories)
               .HasForeignKey(x => x.ProductCategoryId)
               .IsRequired(false);

        List<Categories> categories = new List<Categories>();

        categories.Add(new Categories
            {
                IdCategory = -1,
                CategoryName = "Video Games"
            }
        );
        categories.Add(new Categories
            {
                IdCategory = -2,
                CategoryName = "Movies"
            }
        );
        categories.Add(new Categories
            {
                IdCategory = -3,
                CategoryName = "E-Books"
            }
        );
        
        builder.HasData(categories);


    }
}