using Data.DTOs;
using Data.Services;
using ONIS.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIS.Business.Services
{
    public class ProductService:IProductService
    {
        readonly IProductCatalogRepository _productRepository;
        public ProductService(IProductCatalogRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async ValueTask DeleteProduct(int ProductID)
        {
           await _productRepository.DeleteProduct(ProductID);
        }

        public async ValueTask<ProductDTO> GetProductById(int id)
        {
           return await _productRepository.GetProduct(id);
        }

        public async ValueTask<IEnumerable<ProductDTO>> GetProducts()
        {
            var result= await _productRepository.GetProductsAsync();
            return result;
        }

        public async ValueTask UpdateProduct(int idProduct,ProductDTO ProductDTO)
        {
           await _productRepository.UpdateProduct(idProduct, ProductDTO);   
        }

        
    }
}
