using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BgShop.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BgShop.Data.Repository
{
    public class Repository<T> :IRepository<T> where T : class
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        private string errorMessage = string.Empty;
        public Repository(ApplicationContext _context)
        {
            this.context = _context;

        }

        public async Task Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this.context.Entry(entity).State = EntityState.Deleted;
            await this.context.SaveChangesAsync();
        }

        public async Task<List<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            return await this.Entities.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await this.Entities.FindAsync(id);
        }

        public async Task<T> Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
            return entity;
        }

       

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private DbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }

    }
}