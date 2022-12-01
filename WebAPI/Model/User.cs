using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

            try
            {
                var res = ctx.Users.Add(user);
                //response.Content = res.CurrentValues;
                //response.Content = new StringContent(JsonSerializer);
                await ctx.SaveChangesAsync();
                return 2;
            }
            catch (Exception e)
            {
                return 0;
            }
            return 0;

        }

        public async Task<List<string>> GetUser(List<string> channelIds)
        {
            try
            {
                var status = ctx.Teams.Where(t => channelIds.Contains(t.MSTeamsChannelId)).ToList();
                 List<string> list= new List<string>();
                if (status.Any())
                {
                    foreach( SocioliteTeamProperty team in status)
                    {
                        list.Add(team.MSTeamsChannelId);
                    }
                    return list;
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
            //try
            //{
            //    var dUser = ctx.Users.Where((t) => t.Id == user).ToList().First();
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
            var dUser = ctx.Users.Where(t => t.MSTeamsId == user.MSTeamsId).ToList().First();

            if (dUser != null)
            {
                dUser.FirstName = user.FirstName;
                

                ctx.SaveChanges();
                return StatusCodes.Status200OK;
            }
            return StatusCodes.Status404NotFound;

        }


    }
}
