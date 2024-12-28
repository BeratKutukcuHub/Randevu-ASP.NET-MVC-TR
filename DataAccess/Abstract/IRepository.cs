using Entities;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class 
    {
        public Task AddAsyncEntityAsync(T entity);
        public void AddEntity(T entity);
        public void UpdateEntity(T entity);
        public void RemoveEntity(T entity);
        public void AsyncSave();
    }
}