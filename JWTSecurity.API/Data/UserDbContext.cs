using JWTSecurity.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTSecurity.API.Data;
public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}
