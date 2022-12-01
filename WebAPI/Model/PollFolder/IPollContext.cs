
using Properties;
using System.Net;

namespace WebAPI.Model.PollFolder
{
    public interface IPollContext
    {
       
        Task<HttpStatusCode> PostPoll(CustomPollProperty poll);
        Task<HttpStatusCode> DeletePoll(int id);

    }
}
