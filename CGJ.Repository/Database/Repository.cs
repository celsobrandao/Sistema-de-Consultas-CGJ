using CGJ.Infra.Repository;
using CGJ.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Linq.Expressions;

namespace CGJ.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected readonly DbSet<T> DbSet;

        public Repository(CGJContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public Task<IDbContextTransaction> CreateTransaction()
        {
            return Context.Database.BeginTransactionAsync();
        }

        public Task<IDbContextTransaction> CreateTransaction(IsolationLevel isolation)
        {
            return Context.Database.BeginTransactionAsync(isolation);
        }

        public Task Delete(T entity)
        {
            DbSet.Remove(entity);
            return Context.SaveChangesAsync();
        }

        public async Task<T> Get(object id)
        {
            return await DbSet.FindAsync(id);
        }

        public Task<List<T>> GetAll()
        {
            return DbSet.AsNoTrackingWithIdentityResolution()
                        .ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllByCriteria(Expression<Func<T, bool>> expresssion)
        {
            return await DbSet.AsNoTrackingWithIdentityResolution()
                              .Where(expresssion)
                              .ToListAsync();
        }

        public Task<T> GetOneByCriteria(Expression<Func<T, bool>> expresssion)
        {
            return DbSet.AsNoTrackingWithIdentityResolution()
                        .FirstOrDefaultAsync(expresssion);
        }

        public async Task Save(T entity)
        {
            await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            DbSet.Update(entity);
            return Context.SaveChangesAsync();
        }
    }
}
