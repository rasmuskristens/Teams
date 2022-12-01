using Properties;
using Properties.Team;
using System.Net;

namespace WebAPI.Model.TeamFolder
{
    public interface ITeamContext
    {
        List<SocioliteTeamProperty> GetTeam(int user);
        List<SocioliteTeamProperty> GetTeams();
        int PutTeam(string recurrence, int teamId);

        Task<HttpStatusCode> ChangeActiveStatus(int teamId);
        Task<int> PostTeam(int channelID);
        Task<int> DeleteTeam(int id);
    }
}
