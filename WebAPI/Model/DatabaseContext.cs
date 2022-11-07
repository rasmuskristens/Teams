using Microsoft.EntityFrameworkCore;
using Properties;
using Properties.Team;

namespace WebAPI.Model
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembershipProperty>().HasKey(tm => new { tm.UserId, tm.TeamId });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   // name of database
        //   optionsBuilder.UseSqlite("Data Source = Dnp1ExamLite.db");
        //}

        public DbSet<JoinTeamRequestProperty> JoinTeamRequests { get; set; }
        public DbSet<RoleProperty> Roles { get; set; }
        public DbSet<TeamMembershipProperty> TeamMemberships { get; set; }
        public DbSet<TeamProperty> Teams { get; set; }
        public DbSet<UserProperty> Users { get; set; }


    }
}
