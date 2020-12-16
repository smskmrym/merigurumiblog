using merigurumi.blog.DataAccess.concrete.EFCore.Context;
using merigurumi.blog.DataAccess.Interfaces;
using merigurumi.blog.Entities.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merigurumi.blog.DataAccess.concrete.EFCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new MerigurumiblogContext();
            return await context.Categories.OrderByDescending(I=>I.Id).Include(I => I.CategoryBlogs).ToListAsync();

        }
    }
}
