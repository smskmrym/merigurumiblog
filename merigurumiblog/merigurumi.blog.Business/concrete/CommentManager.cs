using merigurumi.blog.Business.Interfaces;
using merigurumi.blog.DataAccess.Interfaces;
using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
        private readonly IGenericDal<Comment> _genericDal;
        public CommentManager(IGenericDal<Comment> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

    }
}
