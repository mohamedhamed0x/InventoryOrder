using System.Linq.Expressions;

namespace InventoryOrder.Repository
{
    public interface IRepository<T> where T : class
    {
        public void Add(T obj);

        public void Update(T obj);

        public void Delete(int id);

        public IEnumerable<T> GetAll(string include = "");

        public T GetById(int id);

        public void Save();

        public int CountNumber();
        public List<T> GetGroup(Expression<Func<T, bool>> func);

    }
}
