
using Properties;

namespace WebAPI.Model
{
    public interface IUser
    {
        Task<List<string>> GetUser(List<string> channelIds);
        List<UserProperty> GetUsers();
        int PutUser(UserProperty user);
        Task<int> PostUser(UserProperty user);
        int DeleteUser(int id);

    }
}
