using WepApiNet7.Dto;
using WepApiNet7.Models;

namespace WepApiNet7.Interface
{
    public interface IProductService
    {
        void CreateProduct(ProductDTO product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProducts();
        ProductEntity GetProductById(int id);
        void UpdateProduct(int id, ProductDTO product);
    }
}