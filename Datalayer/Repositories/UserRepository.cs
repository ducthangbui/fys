using System.Data.Entity;
using System.Linq;
using Datalayer.Interfaces;
using Model;

namespace Datalayer.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(FYSVersion1Entities db)
            : base(db)
        {
        }

        public UserRepository()
        {
            db = new FYSVersion1Entities();
        }

        public DbSet<User> Users
        {
            get { return GetTable<User>(); }
        }


        public User GetUser(string userName, string password)
        {
            return db.Users.FirstOrDefault(u => u.UserName.Equals(userName) && u.Password.Equals(password));
        }

        public User GetUserByUserName(string userName)
        {
            return db.Users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}