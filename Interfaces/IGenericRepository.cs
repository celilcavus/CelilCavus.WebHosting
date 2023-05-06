namespace CelilCavus.GreenHosting.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);

        void Delete(T item);

        T GetById(int id);

        List<T> GetAll();
    }
}