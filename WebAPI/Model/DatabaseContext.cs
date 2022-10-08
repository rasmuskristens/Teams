using Microsoft.EntityFrameworkCore;

namespace WebAPI.Model
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   // name of database
        //   optionsBuilder.UseSqlite("Data Source = Dnp1ExamLite.db");
        //}

        public DbSet<UserProperty> Users { get; set; }

    }
}
