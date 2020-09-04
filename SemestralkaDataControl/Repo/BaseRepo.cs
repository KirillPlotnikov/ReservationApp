using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SemestralkaDataControl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SemestralkaDataControl.Repo
{
    public class BaseRepo<T> : IDisposable, IRepo<T> where T : class, new()
    {
        private readonly DbSet<T> _table;
        private readonly ApplicationContext _db;
        protected ApplicationContext Context => _db;

        public BaseRepo() : this(new ApplicationContext())
        {
        }
        public BaseRepo(ApplicationContext context)
        {
            _db = context;
            _table = _db.Set<T>();
        }
        public void Dispose()
        {
            _db?.Dispose();
        }

        public int Add(T entity)
        {
            _table.Add(entity);
            return SaveChanges();
        }

        public int Add(IList<T> entities)
        {
            _table.AddRange(entities);
            return SaveChanges();
        }

       
        public T GetOne(int? id) => _table.Find(id);

        public virtual List<T> GetAll() => _table.ToList();
        public List<T> GetAll<TSortField>(Expression<Func<T, TSortField>> orderBy, bool ascending)
            => (ascending ? _table.OrderBy(orderBy) : _table.OrderByDescending(orderBy)).ToList();
        public List<T> GetSome(Expression<Func<T, bool>> where)
            => _table.Where(where).ToList();


        internal int SaveChanges()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch (Exception)
            {
               
                throw;
            }
        }
    }
}
