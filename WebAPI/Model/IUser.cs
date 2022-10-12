
namespace WebAPI.Model
{
    public interface IUser
    {
        UserProperty GetUser(int id);
        List<UserProperty> GetUsers();
        int PutUser(UserProperty user);
        int PostUser(UserProperty user);
        int DeleteUser(int id);

    }
}
