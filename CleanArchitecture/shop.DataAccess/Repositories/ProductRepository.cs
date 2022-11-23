using shop.Entities;

namespace shop.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new()
            {
                new(){ Id=1, Name="ABC", Discount=0.15, Price=5, Description="Test Description 1", CreatedDate=DateTime.Now },
                new(){ Id=2, Name="DEF", Discount=0.15, Price=7, Description="Test Description 2", CreatedDate=DateTime.Now },
                new(){ Id=3, Name="GHI", Discount=0.15, Price=9, Description="Test Description 3", CreatedDate=DateTime.Now },
                new(){ Id=4, Name="JKL", Discount=0.15, Price=12, Description="Test Description 4", CreatedDate=DateTime.Now },
                new(){ Id=5, Name="MNO", Discount=0.15, Price=15, Description="Test Description 5", CreatedDate=DateTime.Now },

            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

        public IEnumerable<Product> SearchProductsByName(string name)
        {
            return _products.Where(p => p.Name.Contains(name)).ToList();
        }
    }
}