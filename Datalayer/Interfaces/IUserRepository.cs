using Model;

namespace Datalayer.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser(string userName, string password);
        User GetUserByUserName(string userName);
    }
}