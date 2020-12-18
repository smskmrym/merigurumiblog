using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace merigurumi.blog.DataAccess.Interfaces
{
    public interface IBlogDal :IGenericDal<Blog>
    {
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog>> GetLastFiveAsync();
    }
}
