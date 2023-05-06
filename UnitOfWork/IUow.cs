using CelilCavus.GreenHosting.Interfaces;

namespace CelilCavus.GreenHosting.UnitOfWork
{
    public interface IUow
    {
        IGenericRepository<T> GetRepository<T>() where T : class;

        int SaveChanges();
    }
}