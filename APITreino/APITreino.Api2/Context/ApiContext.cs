using APITreino.Api2.Models;
using Microsoft.EntityFrameworkCore;

namespace APITreino.Api2.Context
{
    public class ApiContext : DbContext
    {
        #region Properties
        public DbSet<User> Users { get; set; }

        #endregion

        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Maykon Granemann\\Documents\\github\\API\\APITreino\\ApiTreino.Data\\DB.mdf\";Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connectionString);
        }
    }
}
