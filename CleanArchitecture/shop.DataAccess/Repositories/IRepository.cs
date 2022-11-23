using shop.Entities;

namespace shop.DataAccess.Repositories
{
    public interface IRepository<T> where T : IEntity, new()
    {
        List<T> GetAll();
        T GetById(int productId);
    }
}