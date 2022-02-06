using Microsoft.EntityFrameworkCore;

namespace RPC_Authentication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<UserRPC> UserRPC { get; set; }

        
    }

}
