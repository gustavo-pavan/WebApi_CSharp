using Microsoft.EntityFrameworkCore;
using WebAppRest.Models;

namespace WebAppRest.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected UserContext()
        {
        }

        public DbSet<User> Users{get; set;}
    }
}
