using Data.DTOs;
using Data.Entities;

namespace Data.Services
{
    public interface IProductCatalogRepository
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();

        public  Task<ProductDTO> GetProduct(int ProductId);

         public Task DeleteProduct(int ProductId); 
        public Task UpdateProduct(int ProductId, ProductDTO Product);
        public Task AddProduct(ProductDTO Product);
       
        Task SaveChangesAsync();
    }
}
