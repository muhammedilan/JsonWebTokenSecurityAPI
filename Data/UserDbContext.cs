using JsonWebTokenSecurityAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace JsonWebTokenSecurityAPI.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
