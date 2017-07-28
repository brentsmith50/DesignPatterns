using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUnitOfWork.Custom
{
    public class SqlRepository<T> : IRepository<T>
        where T : class, IEntity
    {
        protected ObjectSet<T> objectSet;

        public SqlRepository(ObjectContext context)
        {
            this.objectSet = context.CreateObjectSet<T>();
        }

        public void Add(T newEntity)
        {
            this.objectSet.AddObject(newEntity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.objectSet.Where(predicate);
        }

        public IQueryable<T> FindAll()
        {
            return this.objectSet;
        }

        public T FindById(int id)
        {
            return this.objectSet.Single(o => o.Id == id);
        }

        public void Remove(T entity)
        {
            this.objectSet.DeleteObject(entity);
        }
    }
}
