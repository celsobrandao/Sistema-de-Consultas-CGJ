using System.Linq.Expressions;

namespace CGJ.Infra.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<List<T>> GetAll();
        Task<IEnumerable<T>> GetAllByCriteria(Expression<Func<T, bool>> expresssion);
        Task<T> GetOneByCriteria(Expression<Func<T, bool>> expresssion);
    }
}
