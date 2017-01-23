using System;

namespace Datalayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IRepository<T> GetRepository<T>() where T : class;

        #region Repositories
        IUserRepository UserRepository { get; }
        #endregion
    }
}