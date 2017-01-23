using System;
using System.Collections;
using Datalayer.Interfaces;
using Datalayer.Repositories;
using Model;

namespace Datalayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private FYSVersion1Entities _context;
        private Hashtable _repositories;
        private bool _disposed = false;

        public UnitOfWork()
        {
            _context = new FYSVersion1Entities();
        }

        public int Save()
        {
            // Save changes with the default options
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                            .MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }

        #region Repositories

        private IUserRepository _userRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (this._userRepository == null)
                {
                    this._userRepository = new UserRepository();
                }
                return _userRepository;
            }
        }

        #endregion
    }
}