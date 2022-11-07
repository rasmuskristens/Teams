using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Graph;
using Newtonsoft.Json;
using NuGet.Protocol;
using Properties;
using System.Web.Http;

namespace WebAPI.Model
{
    public class User : ControllerBase, IUser
    {
        private DatabaseContext ctx;

        public User(DatabaseContext db)
        {
            ctx = db;
        }

        public async Task<int> PostUser(UserProperty user)
        {

            //try
            //{
            //    var res = ctx.Users.Add(user);
            //   EntityEntry<RoleProperty> newlyAdded = ctx.Roles.Add(user.Role);
            //    //response.Content = res.CurrentValues;
            //    //response.Content = new StringContent(JsonSerializer);
            //    await ctx.SaveChangesAsync();
            //    return  2;
            //}
            //catch (Exception e)
            //{
            //    return 2;
            //}
            return 0;

        }

        public UserProperty GetUser(int id)
        {
            //try
            //{
            //    var status = ctx.Users.Where(t => t.Id == id).ToList();
            //    if (status.Any())
            //    {
            //        return status.First();
            //    }
            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
            return null;
        }

        public List<UserProperty> GetUsers()
        {
            List<UserProperty> users = (from a in ctx.Users select a).ToList();
            return users;
        }

        int IUser.DeleteUser(int user)
        {
            //try
            //{
            //    var dUser = ctx.Users.Where((t) => t.Id == user).ToList().First();
            //    var Role = ctx.Roles.Where((t) => t.Id == dUser.Role.Id).ToList().First();
            //    if (Role != null)
            //    {
            //        ctx.Roles.Remove(Role);
            //    }
            //    ctx.Users.Remove(dUser);
            //    ctx.SaveChanges();
            //    return StatusCodes.Status200OK;
            //}
            //catch (Exception e)
            //{
            //    return StatusCodes.Status404NotFound;
            //}
            return 0;

        }
        //here is where you post the role that a person has and add in in the role dB
        int IUser.PutUser(UserProperty user)
        {
            var dUser = ctx.Users.Where(t => t.Id == user.Id).ToList().First();

            //if (dUser != null)
            //{
            //    dUser.Id = user.Id;
            //    dUser.Email = user.Email;
            //    dUser.FirstName = user.FirstName;
            //    dUser.LastName = user.LastName;

            //    var role = ctx.Roles.Where(t => t.Id == dUser.Role.Id).ToList().First();
            //    if (role != null)
            //    {
            //        dUser.Role = role;
            //        role.Name = dUser.Role.Name;
            //        ctx.SaveChanges();
            //    }
            //    else
            //    {
            //        EntityEntry<RoleProperty> newlyAdded = ctx.Roles.Add(dUser.Role);
            //        ctx.SaveChanges();
            //    }


            //    ctx.SaveChanges();
            //    return StatusCodes.Status200OK;
            //}
            return StatusCodes.Status404NotFound;

        }


    }
}
