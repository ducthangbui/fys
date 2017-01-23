using Datalayer.Interfaces;
using Model;
using Service.Interfaces;

namespace Service.Serivices
{
    public class UserService : BaseService, IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUnitOfWork uow)
        {
            this._userRepository = uow.UserRepository;
        }
        public User GetUser(string userName, string passWord)
        {
            return _userRepository.GetUser(userName, passWord);
        }

        public User GetUserByUserName(string userName)
        {
            return _userRepository.GetUserByUserName(userName);
        }
    }
}