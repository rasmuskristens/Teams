

namespace WebAPI.Model
{
    public class User : IUser
    {
        private DatabaseContext ctx;

        public User(DatabaseContext db)
        {
            ctx = db;
        }
        public List<UserProperty> GetUsers()
        {
            List<UserProperty> users = (from a in ctx.Users select a).ToList();
            return users;
        }
    }
}
