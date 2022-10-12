

using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using NuGet.Protocol;

namespace WebAPI.Model
{
    public class User : ControllerBase,IUser
    {
        private DatabaseContext ctx;

        public User(DatabaseContext db)
        {
            ctx = db;
        }

        public int PostUser(UserProperty user)
        {
            try
            {
                ctx.Users.Add(user);
                return StatusCodes.Status200OK;
            }
            catch(Exception e)
            {
                return StatusCodes.Status404NotFound;
            }
            
        }

        public UserProperty GetUser(int id)
        {
            try
            {
                var status = ctx.Users.Where(t => t.Id == id).ToList();
                if (status.Any())
                {
                    return status.First();
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }

        public List<UserProperty> GetUsers()
        {
            List<UserProperty> users = (from a in ctx.Users select a).ToList();
            return users;
        }

        int IUser.DeleteUser(int user)
        {
            try
            {
                var dUser = ctx.Users.Where((t) => t.Id == user).ToList().First();
                var response = ctx.Users.Remove(dUser);
                return StatusCodes.Status200OK;
            }
            catch(Exception e)
            {
                return StatusCodes.Status404NotFound;
            }

        }

        int IUser.PutUser(UserProperty user)
        {
            var dUser = ctx.Users.Where(t=> t == user).ToList().First();

            if(dUser != null)
            {
                dUser.Id = user.Id;
                dUser.Email = user.Email;
                dUser.FirstName = user.FirstName;
                dUser.LastName = user.LastName;
                dUser.Roles = user.Roles;
                dUser.IsCreated = user.IsCreated;
                return StatusCodes.Status200OK;
            }
            return StatusCodes.Status404NotFound;

        }
    }
}
