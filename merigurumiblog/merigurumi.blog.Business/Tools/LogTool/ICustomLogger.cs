using System;
using System.Collections.Generic;
using System.Text;

namespace merigurumi.blog.Business.Tools.LogTool
{
    public interface ICustomLogger
    {
        void LogError(string message);
    }
}
