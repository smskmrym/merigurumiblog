using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.DTO.DTOs.CategoryDtos
{
    public class CategoryWithBlogsCountDto
    {
        public int BlogCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
