using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IProductRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProductDTO> Create(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);

            await _repository.Create(product);

            return productDTO;
        }

        public async Task<ProductDTO> Delete(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);

            await _repository.Delete(product);

            return productDTO;
        }

        public async Task<ProductDTO> GetProductByCategoryById(int? id)
        {
            var productDTO = _mapper.Map<ProductDTO>( await _repository.GetProductByCategoryById(id));

            return productDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(await _repository.GetProducts());

            return productDTOs;
        }

        public async Task<ProductDTO> ProductById(int? id)
        {
            var productDTO =  _mapper.Map<ProductDTO>(await _repository.ProductById(id));

            return productDTO;
        }

        public async Task<ProductDTO> Update(ProductDTO productDTO)
        {
            Product product = _mapper.Map<Product>(productDTO);

            await _repository.Update(product);

            return productDTO;
        }
    }
}
