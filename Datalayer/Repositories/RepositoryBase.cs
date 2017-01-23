using Datalayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Model;

namespace Datalayer.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected FYSVersion1Entities db;
        private DbSet<T> table;

        public RepositoryBase()
        {
            db = new FYSVersion1Entities();
            table = db.Set<T>();
        }

        public RepositoryBase(FYSVersion1Entities db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public DbSet<T> GetTable()
        {
            return table;
        }

        protected DbSet<T1> GetTable<T1>()
            where T1 : class
        {
            return db.Set<T1>();
        }

        public virtual void Create(T obj)
        {
            table.Add(obj);
        }

        public virtual void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public virtual IList<T> GetAll()
        {
            return table.ToList();
        }

        public virtual IList<T> GetMany(Expression<Func<T, bool>> whereCondition)
        {
            return table.Where(whereCondition).ToList();
        }

        public virtual T GetByID(object id)
        {
            return table.Find(id);
        }

        public virtual T GetSingle(Expression<Func<T, bool>> whereCondition)
        {
            return table.FirstOrDefault(whereCondition);
        }

        public virtual void Save()
        {
            db.SaveChanges();
        }

        public virtual async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}