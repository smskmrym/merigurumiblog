using merigurumi.blog.DataAccess.Interfaces;
using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.DataAccess.concrete.EFCore.Repositories
{
    public class EfCommentRepository : EfGenericRepository<Comment>, ICommentDal
    {
    }
}
