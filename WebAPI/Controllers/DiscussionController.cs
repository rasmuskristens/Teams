using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Properties;
using Properties.Team;
using System.Net;
using System.Text.Json.Nodes;
using WebAPI.Model;
using WebAPI.Model.DisccusionFolder;
using WebAPI.Model.TeamFolder;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscussionController : ControllerBase
    {
        private IDiscussionContext DiscussionContext;

        public DiscussionController(IDiscussionContext disucssion)
        {
            this.DiscussionContext = disucssion;
        }
        

        // POST api/<UserController>
        [HttpPost]
        public async Task<HttpStatusCode> Post([FromBody] CustomDiscussionProperty discussion)
        {
            return await DiscussionContext.PostDiscussion(discussion);

        }

        

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> Delete(int id)
        {
            return await DiscussionContext.DeleteDiscussion(id);
        }

        

    }
}
