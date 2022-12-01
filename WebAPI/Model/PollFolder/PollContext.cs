using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using NuGet.Protocol;
using Properties;
using System.Net;
using System.Web.Http;

namespace WebAPI.Model.PollFolder
{
    public class PollContext : IPollContext
    {
        private DatabaseContext ctx;

        public PollContext(DatabaseContext db)
        {
            ctx = db;
        }

        public async Task<HttpStatusCode> DeletePoll(int id)
        {
            var poll = await ctx.CustomPolls.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (poll != null)
            {
                ctx.Remove(poll);
                var res = await ctx.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            return HttpStatusCode.NotFound;
        }

        public async Task<HttpStatusCode> PostPoll(CustomPollProperty poll)
        {
            if (poll != null)
            {
                await ctx.CustomPolls.AddAsync(poll);
                await ctx.SaveChangesAsync();
                return HttpStatusCode.OK;
            }
            return HttpStatusCode.NotAcceptable;
        }
    }
}
