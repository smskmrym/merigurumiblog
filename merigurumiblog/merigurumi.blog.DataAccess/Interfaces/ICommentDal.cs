using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace merigurumi.blog.DataAccess.Interfaces
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}
