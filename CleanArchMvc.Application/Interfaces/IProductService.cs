using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<ProductDTO> ProductById(int? id);
         
        public Task<ProductDTO> GetProductByCategoryById(int? id);
         
        public Task<ProductDTO> Create(ProductDTO productDTO);
        public Task<ProductDTO> Update(ProductDTO productDTO);
        public Task<ProductDTO> Delete(ProductDTO productDTO);
    }
}
