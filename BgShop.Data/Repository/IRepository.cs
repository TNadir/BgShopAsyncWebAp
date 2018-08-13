using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BgShop.Data.Repository
{
    public interface IRepository<T> where T
     : class
    {
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<List<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task Delete(T entity);
    }
}