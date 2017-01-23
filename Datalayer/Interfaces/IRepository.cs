using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Datalayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> GetTable();

        /// <summary>
        /// Get all the element of this repository
        /// </summary>
        /// <returns>
        IList<T> GetAll();

        /// <summary>
        /// Load the entities using a linq expression filter
        /// </summary>
        /// <typeparam name="T">the entity type to load</typeparam>
        /// <param name="where">where condition</param>
        /// <returns>the loaded entity</returns>
        IList<T> GetMany(Expression<Func<T, bool>> whereCondition);

        /// <summary>
        /// Get a selected extiry by the object primary key ID
        /// </summary>
        /// <param name="id">Primary key ID</param>
        T GetByID(object id);

        /// <summary>
        /// Get a selected extiry by using a linq expression filter
        /// </summary>
        /// <typeparam name="T">the entity type to get</typeparam>
        /// <param name="where">where condition</param>
        T GetSingle(Expression<Func<T, bool>> whereCondition);

        /// <summary>
        /// Add entity to the repository
        /// </summary>
        /// <param name="obj">the entity to add</param>
        void Create(T obj);

        /// <summary>
        /// Updates entity within the the repository
        /// </summary>
        /// <param name="obj">the entity to update</param>
        /// <returns>The updates entity</returns>
        void Update(T obj);

        /// <summary>
        /// Mark entity to be deleted within the repository
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        void Save();

        Task SaveAsync();
    }
}