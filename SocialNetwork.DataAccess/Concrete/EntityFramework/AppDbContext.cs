using Microsoft.EntityFrameworkCore;
using SocialNetwork.Core.Entities;

namespace SocialNetwork.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LES9OTM; Initial Catalog=SocialNetworkDb; Trusted_Connection=true; MultipleActiveResultSets=true")
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}