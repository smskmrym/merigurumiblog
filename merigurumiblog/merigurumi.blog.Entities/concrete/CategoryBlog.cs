using merigurumi.blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Entities.concrete
{
   public class CategoryBlog : ITable
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
