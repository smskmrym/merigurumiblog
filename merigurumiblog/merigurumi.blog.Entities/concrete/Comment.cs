using merigurumi.blog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Entities.concrete
{
    public class Comment : ITable
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public List<Comment> SubComments { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
