using Model;

namespace Service.Interfaces
{
    public interface IUserService
    {
        User GetUser(string userName, string passWord);
        User GetUserByUserName(string userName);
    }
}