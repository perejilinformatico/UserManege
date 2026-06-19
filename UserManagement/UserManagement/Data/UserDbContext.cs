using Microsoft.EntityFrameworkCore;
using UserManagement.Client.Models;

namespace UserManagement.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}
