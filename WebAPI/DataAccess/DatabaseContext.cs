using ItemProperties;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DataAccess
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
         : base(options)
        {
        }


        DbSet<UserProperty> Users { get; set; }


    }
}
