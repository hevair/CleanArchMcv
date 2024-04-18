using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> ProductById(int? id);

        Task<Product> GetProductByCategoryById(int? id);

        Task<Product> Create(Product produc);
        Task<Product> Update(Product product);
        Task<Product> Delete(Product product);

    }
}
