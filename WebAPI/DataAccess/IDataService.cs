using ItemProperties;

namespace WebAPI.DataAccess
{
    public interface IDataService
    {

        //User CRUD

        List<UserProperty> GetAllUserProperty();
        UserProperty GetUserProperty(int id);
        UserProperty CreateUserProperty(UserProperty user);
        List<UserProperty> UpdateUserProperty(UserProperty user);
        List<UserProperty> DeleteUserProperty(UserProperty user);

    }
}
