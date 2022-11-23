using shop.Application.DTOs.Requests;
using shop.Application.DTOs.Responses;
using shop.DataAccess.Repositories;
using shop.Entities;

namespace shop.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;


        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public void CreateProduct(AddProductRequest addProductRequest)
        {
            throw new NotImplementedException();
        }

        public ProductDisplayResponse GetProduct(int productId)
        {

            Product product = productRepository.GetById(productId);
            return new ProductDisplayResponse
            {
                Id = product.Id,
                Description = product.Description,
                Discount = product.Discount,
                Name = product.Name,
                Price = product.Price,
            };

        }

        public List<ProductDisplayResponse> GetProducts()
        {
            List<Product> products = productRepository.GetAll();
            var productsDto = products.Select(p => new ProductDisplayResponse
            {
                Price = p.Price,
                Description = p.Description,
                Discount = p.Discount,
                Name = p.Name,
                Id = p.Id
            }).ToList();

            return productsDto;

        }
    }
}