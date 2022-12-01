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
            modelBuilder.Entity<SocioliteTeamMembershipProperty>().HasKey(tm => new { tm.UserId, tm.TeamId });
            modelBuilder.Entity<ActivityOccurenceProperty>().HasKey(tm => new { tm.TeamId, tm.ActivityOccuranceId});
            modelBuilder.Entity<PollVoteProperty>().HasKey(tm => new { tm.UserId, tm.ActivityOccuranceId });


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   // name of database
        //   optionsBuilder.UseSqlite("Data Source = Dnp1ExamLite.db");
        //}

        public DbSet<ActivityOccurenceProperty> Activities { get; set; }
        
        public DbSet<PollVoteProperty> PollVotes { get; set; }
        public DbSet<SocioliteTeamMembershipProperty> TeamMemberships { get; set; }

        public DbSet<SocioliteTeamProperty> Teams { get; set; }
        public DbSet<UserProperty> Users { get; set; }

        public DbSet<CustomDiscussionProperty> CustomDiscussions { get;set; }

        public DbSet<CustomPollProperty> CustomPolls { get; set; }





    }
}
