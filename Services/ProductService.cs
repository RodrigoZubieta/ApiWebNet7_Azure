using WepApiNet7.Data;
using WepApiNet7.Dto;
using WepApiNet7.Interface;
using WepApiNet7.Models;

namespace WepApiNet7.Services
{
    public class ProductService : IProductService
    {
        public readonly StoreDbContext _context;
        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }


        public void CreateProduct(ProductDTO product)
        {
            var productEntity = new ProductEntity
            {
                Name = product.Name,
                DateCreate = DateTime.Now,
                Description = product.Description,
                Stock = product.Stock,
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public ProductEntity GetProductById(int id) => _context.Products.SingleOrDefault(p => p.Id == id);

        public void UpdateProduct(int id, ProductDTO product)
        {
            var productEntity = GetProductById(id);
            if (productEntity == null)
            {
                throw new Exception($"Product not found: id.: {id}");
            }
            productEntity.DateCreate = DateTime.Now;
            productEntity.Stock = product.Stock;
            productEntity.Name = product.Name;
            productEntity.Description = product.Description;

            _context.Products.Update(productEntity);
            _context.SaveChanges(true);
        }

        public void DeleteProduct(int id)
        {
            var productEntity = GetProductById(id);
            if (productEntity == null)
            {
                throw new Exception($"Product not found: id.: {id}");
            }
            _context.Products.Remove(productEntity);
            _context.SaveChanges();
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
