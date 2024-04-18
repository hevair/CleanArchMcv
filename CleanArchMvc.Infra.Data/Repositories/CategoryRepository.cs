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
    public class CategoryRepository : ICategoryRepository
    {

        ApplicationDBContext _categoryRepository;

        public CategoryRepository(ApplicationDBContext context)
        {
            _categoryRepository = context;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryRepository.Categories.ToListAsync();
        }
        public async Task<Category> CategoryById(int? id)
        {
           return await _categoryRepository.Categories.FindAsync(id);

        }

        public async Task<Category> Create(Category category)
        {
             _categoryRepository.Add(category);

            await _categoryRepository.SaveChangesAsync();

            return category;

        }

        public async Task<Category> Delete(Category category)
        {
            _categoryRepository.Categories.Remove(category);

            await _categoryRepository.SaveChangesAsync();

            return category;
        }


        public async Task<Category> Update(Category category)
        {
            _categoryRepository.Categories.Update(category);

            await _categoryRepository.SaveChangesAsync();

            return category;
        }
    }
}
