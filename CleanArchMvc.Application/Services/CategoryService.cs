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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CategoryDTO> CategoryById(int? id)
        {
            var categoryEntity = await _categoryRepository.CategoryById(id);

            return _mapper.Map<CategoryDTO>(categoryEntity);

        }

        public async Task<CategoryDTO> Create(CategoryDTO categoryDTO)
        {

            var categoryEntity = _mapper.Map<Category>(categoryDTO);

            var newCategoryDTO = await _categoryRepository.Create(categoryEntity);

            return _mapper.Map<CategoryDTO>(newCategoryDTO);

        }

        public async Task<CategoryDTO> Delete(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);

            var deletedCategoryDTO = await _categoryRepository.Delete(categoryEntity);

            return _mapper.Map<CategoryDTO>(deletedCategoryDTO);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoryEntity = await _categoryRepository.GetCategories();

            return _mapper.Map<IEnumerable<CategoryDTO>>(categoryEntity);
        }

        public async Task<CategoryDTO> Update(CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);

            var updateCategory = await _categoryRepository.Update(categoryEntity);

            return _mapper.Map<CategoryDTO>(updateCategory);
        }
    }
}
