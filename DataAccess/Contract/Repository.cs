
using DataAccess.Abstract;
using DataAccess.DbContextEfCore;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public EntityFrameworkDbContext _context;

        public Repository(EntityFrameworkDbContext context)
        {
            _context = context;
        }
        public async Task AddAsyncEntityAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public void AddEntity(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void UpdateEntity(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public void RemoveEntity(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void AsyncSave()
        {
             _context.SaveChanges();
        }
    }
}