using shop.Entities;

namespace shop.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> SearchProductsByName(string name);

    }
}