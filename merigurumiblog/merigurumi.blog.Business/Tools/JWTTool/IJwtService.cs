using merigurumi.blog.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
