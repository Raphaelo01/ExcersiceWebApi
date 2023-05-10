using Data.DTOs;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONIS.Business.Interfaces
{
    public interface IProductService
    {
        public  ValueTask<IEnumerable<ProductDTO>> GetProducts();
        public ValueTask<ProductDTO> GetProductById(int id);
        public ValueTask DeleteProduct(int ProductID);
        public ValueTask UpdateProduct(int ProductId,ProductDTO ProductDTO);
    }
}
