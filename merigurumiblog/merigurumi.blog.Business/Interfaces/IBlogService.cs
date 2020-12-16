using merigurumi.blog.DTO.DTOs.CategoryBlogDtos;
using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace merigurumi.blog.Business.Interfaces
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<List<Blog>> GetAllSortedByPostedTimeAsync();
        Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);


    }
}
