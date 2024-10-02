using BlazorECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorECommerce.Configurations;

public class ProductsConfig : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.HasKey(x => x.IdProduct);
        builder.Property(x => x.IdProduct).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.ProductName).IsRequired();
        builder.Property(x => x.ProductDescription).IsRequired();
        builder.Property(x => x.ProductPrice).IsRequired();
        builder.Property(x => x.ProductIcon).IsRequired().HasDefaultValue("https://www.google.com/url?sa=i&url=https%3A%2F%2Fsemantic-ui.com%2Fviews%2Fitem.html&psig=AOvVaw0Xo_P44PaOlMatyB3B9noF&ust=1727916298271000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCOChlPy77ogDFQAAAAAdAAAAABAE");
        builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
        
        List<Products> products = new List<Products>();
        
        products.Add(new Products()
        {
            IdProduct = -1,
            ProductName = "The Elder Scrolls III: Morrowind",
            ProductDescription = "The Elder Scrolls III: Morrowind is a 2002 action role-playing game developed by Bethesda Game Studios and published by Bethesda Softworks. It is the third installment in The Elder Scrolls series, following 1996's The Elder Scrolls II: Daggerfall, and was released for Microsoft Windows and Xbox.",
            ProductCategoryId = -1,
            ProductPrice = 30.25,
            ProductIcon = "https://upload.wikimedia.org/wikipedia/en/5/53/MorrowindCOVER.jpg",
            IsActive = true,
        });
        products.Add(new Products()
        {
            IdProduct = -2,
            ProductName = "The Lord of the Rings",
            ProductDescription = "The Lord of the Rings is an epic high fantasy novel by the English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.",
            ProductCategoryId = -3,
            ProductPrice = 12.5,
            ProductIcon = "https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif",
            IsActive = true,
        });
        products.Add(new Products()
        {
            IdProduct = -3,
            ProductName = "The Shawshank Redemption",
            ProductDescription = "The Shawshank Redemption is a 1994 American prison drama film written and directed by Frank Darabont, based on the 1982 Stephen King novella Rita Hayworth and Shawshank Redemption. The film tells the story of banker Andy Dufresne (Tim Robbins), who is sentenced to life in Shawshank State Penitentiary for the murders of his wife and her lover, despite his claims of innocence.",
            ProductCategoryId = -2,
            ProductPrice = 10,
            ProductIcon = "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg",
            IsActive = true,
        });
        builder.HasData(products);
    }
}