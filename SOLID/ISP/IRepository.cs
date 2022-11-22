namespace ISP
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);


    }

    public class Product
    {

    }


    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> GetProductsByPrice(decimal price);
    }

    public class ProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsByPrice(decimal price)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {

    }
    public class UserRepository : IRepository<User>
    {
        public void Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
