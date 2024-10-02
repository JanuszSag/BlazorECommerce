using BlazorECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorECommerce.Configurations;

public class UsersConfig : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.HasKey(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.Username).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
        builder.Property(x => x.PasswordHash);
        builder.Property(x => x.PasswordSalt);
        builder.Property(x => x.IsAdmin).IsRequired().HasDefaultValue(0);
        builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(1);
        
        builder.HasMany(x => x.Orders)
               .WithOne(x => x.Users)
               .HasForeignKey(x => x.IdOrder);
        
        List<Users> users = new List<Users>();
        
        users.Add(new Users()
        {
            UserId = -1,
            Username = "admin",
        });
    }
}