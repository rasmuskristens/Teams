using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser user;

        public UserController(IUser user)
        {
            this.user = user;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<UserProperty> Get()
        {

            return user.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserProperty Get(int id)
        {
            var userId = user.GetUser(id);
            if (userId!= null)
            {
                return userId;
            }
            return null;
            
        }

        // POST api/<UserController>
        [HttpPost]
        public int Post([FromBody] UserProperty value)
        {
            return user.PostUser(value);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public int Put([FromBody] UserProperty value)
        {
            return user.PutUser(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return user.DeleteUser(id);
        }
    }
}
