using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.Stringinfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:60946";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "MeriMeri";
        public const double Expires = 40;
    }
}
