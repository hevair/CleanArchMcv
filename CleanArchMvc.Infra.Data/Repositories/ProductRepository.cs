using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDBContext _productContext;
        public ProductRepository(ApplicationDBContext context)
        {
            _productContext = context;
        }

        

        public async Task<Product> GetProductByCategoryById(int? id)
        {
            return await _productContext.Products.Include(p => p.Category).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productContext.Products.ToListAsync();
        }

        public async Task<Product> ProductById(int? id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        public async Task<Product> Create(Product product)
        {
            _productContext.Products.Add(product);

            await _productContext.SaveChangesAsync();

            return product;
        }

        public async Task<Product> Delete(Product product)
        {
             _productContext.Products.Remove(product);

            await _productContext.SaveChangesAsync();

            return product;
        }
        public async Task<Product> Update(Product product)
        {
            _productContext.Products.Update(product);
            await _productContext.SaveChangesAsync();

            return product;
        }
    }
}
