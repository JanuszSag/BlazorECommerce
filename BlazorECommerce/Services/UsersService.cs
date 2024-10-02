using BlazorECommerce.Models;

namespace BlazorECommerce.Services;

public class UsersService(ECommerceContext _context)
{
    public async Task AddUserAsync(Users user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}