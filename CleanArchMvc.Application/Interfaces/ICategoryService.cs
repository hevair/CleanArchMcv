using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> CategoryById(int? id);
        Task<CategoryDTO> Create(CategoryDTO categoryDTO);
        Task<CategoryDTO> Update(CategoryDTO categoryDTO);
        Task<CategoryDTO> Delete(CategoryDTO categoryDTO);
    }
}
