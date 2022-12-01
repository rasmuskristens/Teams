using Properties;
using Properties.Team;
using System.Net;

namespace WebAPI.Model.TeamFolder
{
    public class TeamContext : ITeamContext
    {
        private DatabaseContext ctx;

        public TeamContext(DatabaseContext db)
        {
            ctx = db;
        }

        public async Task<int> PostTeam(int channelID)
        {

            try
            {
                var team = new SocioliteTeamProperty();
                team.MSTeamsChannelId = channelID.ToString();
                team.Recurring = "0000000";
                var res = ctx.Teams.Add(team);
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




        public List<SocioliteTeamProperty> GetTeam(int id)
        {
            try
            {
                var teams =  ctx.Teams.Where(t => t.TeamId == id).ToList();
                return teams;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return null;
        }

        public List<SocioliteTeamProperty> GetTeams()
        {
            //List<TeamProperty> teams = (from a in ctx.Teams select a).ToList();
            //return new List<TeamProperty>();
            return null;
        }

        public int PutTeam(string recurrence, int teamId)
        {
           SocioliteTeamProperty user = ctx.Teams.Where(t=>t.TeamId == teamId).ToList().First();

            user.Recurring = recurrence;

            ctx.SaveChanges();
            return 2;

        }

        public async Task<HttpStatusCode> ChangeActiveStatus( int teamId)
        {
            try
            {
                SocioliteTeamProperty user = ctx.Teams.Where(t => t.TeamId == teamId).First();
                
                    if (user.isActive)
                    {
                        user.isActive = false;
                    }
                    else
                    {
                        user.isActive = true;
                    }
                    await ctx.SaveChangesAsync();
                    return HttpStatusCode.OK;
                
            }
            catch(Exception e)
            {
                return HttpStatusCode.NotFound;
            }
           

            

        }

        public async Task<int> DeleteTeam(int id)
        {
            //try
            //{
            //    var team = ctx.Teams.Where((t) => t.Id == id).ToList();
            //    if (team.Any())
            //    {
            //        ctx.Teams.Remove(team.First());
            //        await ctx.SaveChangesAsync();
            //        return StatusCodes.Status200OK;
            //    }

            //    return StatusCodes.Status404NotFound;
                
            //}
            //catch (Exception e)
            //{
            //    return StatusCodes.Status404NotFound;
            //}
            return 0;
        }
    }
}
