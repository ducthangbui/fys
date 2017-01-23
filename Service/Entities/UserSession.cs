using Model;

namespace Service.Entities
{
    public class UserSession
    {
        public UserSession(User user)
        {
            User = user;
        }
        public User User { get; set; }
    }
}