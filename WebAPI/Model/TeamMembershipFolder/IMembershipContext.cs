using Newtonsoft.Json.Linq;
using Properties;
using Properties.Team;
using System.Text.Json.Nodes;

namespace WebAPI.Model.MembershipFolder
{
    public interface IMembershipContext
    {
        List<Object> GetMembership(List<int> data);
        Task<List<SocioliteTeamMembershipProperty>> GetMemberships();
        Task<int> PutMembership(int teamId,JsonObject jsonObject);
        Task<int> PostMembership(SocioliteTeamProperty data,int userId);
        Task<int> DeleteMembership(int id);
    }
}
