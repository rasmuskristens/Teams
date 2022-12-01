
using Properties;
using System.Net;

namespace WebAPI.Model.DisccusionFolder
{
    public interface IDiscussionContext
    {
       
        Task<HttpStatusCode> PostDiscussion(CustomDiscussionProperty disucssion);
        Task<HttpStatusCode> DeleteDiscussion(int id);

    }
}
