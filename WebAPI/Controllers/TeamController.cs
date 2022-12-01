using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Properties;
using Properties.Team;
using System.Net;
using System.Text.Json.Nodes;
using WebAPI.Model;
using WebAPI.Model.TeamFolder;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamContext team;

        public TeamController(ITeamContext team)
        {
            this.team = team;
        }
        // GET: api/<UserController>
        //[HttpGet]
        //public List<string> Get()
        //{

        //    //return team.GetTeams();
        //    return null;
        //}

        // GET api/<UserController>/5
        [HttpGet()]
        public List<SocioliteTeamProperty> Get([FromHeader] int userId)
        {
            var TeamId = team.GetTeam(userId);
            if (TeamId != null)
            {
                return TeamId;
            }
            return null;

        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<int> Post([FromHeader] int value)
        {
            return await team.PostTeam(value);

        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public int Put([FromHeader] int teamId, [FromBody] JsonObject Recurring)
        {
            string re = Recurring.First().Value.ToString();
            return team.PutTeam(re, teamId);
            //return 0;
        }


        [HttpPut("{teamId}")]
        public async Task<HttpStatusCode> Put(int teamId)
        {
            
            return await team.ChangeActiveStatus(teamId);
            //return 0;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await team.DeleteTeam(id);
        }

    }
}
