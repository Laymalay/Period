using Microsoft.EntityFrameworkCore;
using Period.Models;

namespace AuthApp.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
    }
}