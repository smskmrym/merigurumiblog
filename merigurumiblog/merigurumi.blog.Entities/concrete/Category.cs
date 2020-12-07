using merigurumi.blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Entities.concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
