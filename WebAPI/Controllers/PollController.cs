using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Properties;
using Properties.Team;
using System.Net;
using System.Text.Json.Nodes;
using WebAPI.Model;
using WebAPI.Model.DisccusionFolder;
using WebAPI.Model.PollFolder;
using WebAPI.Model.TeamFolder;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollController : ControllerBase
    {
        private IPollContext PollContext;

        public PollController(IPollContext poll)
        {
            this.PollContext = poll;
        }
        

        // POST api/<UserController>
        [HttpPost]
        public async Task<HttpStatusCode> Post([FromBody] CustomPollProperty poll)
        {
            return await PollContext.PostPoll(poll);

        }

        

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> Delete(int id)
        {
            return await PollContext.DeletePoll(id);
        }

        

    }
}
