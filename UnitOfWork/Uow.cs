using CelilCavus.GreenHosting.Interfaces;
using CelilCavus.GreenHosting.Repository;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.GreenHosting.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly DbContext _context;
        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}