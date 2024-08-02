using Microsoft.EntityFrameworkCore;
using APITreino.Core.Models;
namespace APITreino.Infrastructure.Database
{
    public class ApiContext : DbContext
    {
        #region Properties
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        #endregion

        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Maykon Granemann\\Documents\\github\\API\\APITreino\\APITreino.Infrastructure\\Database\\DBApi.mdf\";Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
            .HasOne(p => p.User)
            .WithOne(c => c.Profile)
            .HasForeignKey<UserProfile>(c => c.UserID); 
            
            //base.OnModelCreating(modelBuilder);

        }
    }
}
