using CelilCavus.GreenHosting.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.GreenHosting.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
        }
    }
}