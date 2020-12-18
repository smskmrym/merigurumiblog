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
    public class EfCommentRepository : EfGenericRepository<Comment>, ICommentDal
    {
        public async Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            List<Comment> result = new List<Comment>();
            await GetComments(blogId, parentId, result);
                return result;
        }

        private async Task GetComments(int blogId, int? parentId, List<Comment> result)
        {
            using var context = new MerigurumiblogContext(); 
            var comments = await context.Comments.Where(I => I.BlogId == blogId && I.ParentCommentId == parentId).OrderByDescending(I => I.PostedTime).ToListAsync();
            if(comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    if (comment.SubComments == null)
                        comment.SubComments = new List<Comment>();

                    await GetComments(comment.BlogId, comment.Id, comment.SubComments);

                    if(!result.Contains(comment))
                    {
                        result.Add(comment);
                    }
                }
            }
        }
    }
}
