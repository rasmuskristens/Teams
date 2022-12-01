using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Properties;
using Properties.Team;
using System.Text.Json.Nodes;
using WebAPI.Model;
using WebAPI.Model.MembershipFolder;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        // GET: MembershipController

        private IMembershipContext membership;

        public MembershipController(IMembershipContext membership)
        {
            this.membership = membership;
        }

        // GET: api/<UserController>
        //[HttpGet]
        //public async Task<List<SocioliteTeamMembershipProperty>> Get()
        //{
        //    //return await membership.GetMemberships();
        //    return new List<SocioliteTeamMembershipProperty>();
        //}


        

        // GET api/<UserController>/5
        [HttpGet]
        public List<Object> Get([FromBody]List<int> data)
        {
            var membershipId = membership.GetMembership(data);
            if (membershipId != null)
            {
                return membershipId;
            }
            return null;

        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<int> Post([FromBody] SocioliteTeamProperty data, [FromHeader] int userId)
        {
            return await membership.PostMembership(data,userId);
            return 2;
        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public async Task<int> Put([FromHeader] int teamId, [FromBody] JsonObject jsonObject)
        {
            return await membership.PutMembership(teamId,jsonObject);
            return 0;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await membership.DeleteMembership(id);
        }
    }
}
