﻿using merigurumi.blog.DataAccess.concrete.EFCore.Context;
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
    public class EfBlogRepository : EfGenericRepository<Blog>, IBlogDal
    {
        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            using var context = new MerigurumiblogContext();
            return await context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId, (blog, categoryBlog) => new
            {
                blog,
                categoryBlog
            }).Where(I => I.categoryBlog.CategoryId == categoryId).Select(I => new Blog
            {
                AppUser = I.blog.AppUser,
                AppUserId = I.blog.AppUserId,
                CategoryBlogs = I.blog.CategoryBlogs,
                Comments = I.blog.Comments,
                Description = I.blog.Description,
                Id = I.blog.Id,
                ImagePath = I.blog.ImagePath,
                PostedTime = I.blog.PostedTime,
                ShortDescription = I.blog.ShortDescription,
                Title = I.blog.Title
            }).ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            using var context = new MerigurumiblogContext();
            return await context.Categories.Join(context.CategoryBlogs, c => c.Id, cb => cb.CategoryId, (category, categoryBlog) => new
            {
                category,
                categoryBlog
            }).Where(I => I.categoryBlog.BlogId == blogId).Select(I => new Category
            {
                Id = I.category.Id,
                Name = I.category.Name
            }).ToListAsync();
        }

        public async Task<List<Blog>> GetLastFiveAsync()
        {
            using var context = new MerigurumiblogContext();
            return await context.Blogs.OrderByDescending(I => I.PostedTime).Take(5).ToListAsync();
        }
    }
    
}
