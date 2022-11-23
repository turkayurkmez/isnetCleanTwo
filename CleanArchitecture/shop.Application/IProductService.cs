using shop.Application.DTOs.Requests;
using shop.Application.DTOs.Responses;

namespace shop.Application
{
    public interface IProductService
    {
        List<ProductDisplayResponse> GetProducts();
        ProductDisplayResponse GetProduct(int productId);

        void CreateProduct(AddProductRequest addProductRequest);
    }
}