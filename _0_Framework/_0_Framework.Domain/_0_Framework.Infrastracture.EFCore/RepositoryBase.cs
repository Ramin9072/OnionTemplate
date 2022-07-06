
using Microsoft.EntityFrameworkCore;

namespace _0_Framework._0_Framework.Domain._0_Framework.Infrastracture.EFCore
{
    public class RepositoryBase<Tkey, T> : IRepository<Tkey, T> where T : class
    {
        private readonly DbContext _dbContext;
        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity) => _dbContext.Add<T>(entity);

        public T Edit(Tkey key) => _dbContext.Find<T>(key);

        public bool Exist(Func<T, bool> expression) => _dbContext.Set<T>().Any(expression);

        public T Get(Tkey key) => _dbContext.Find<T>(key);

        public List<T> List() => _dbContext.Set<T>().ToList(); 

        public void SaveChanges() => _dbContext.SaveChanges();
    }
}
