#pragma checksum "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca37aa1856ffce092c0aea9db26e3cae0010b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_PostListeleWidget), @"mvc.1.0.view", @"/Controllers/PostListeleWidget.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca37aa1856ffce092c0aea9db26e3cae0010b5e", @"/Controllers/PostListeleWidget.cshtml")]
    public class Controllers_PostListeleWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<merigurumiblog.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n\r\n\r\n    <div class=\"blog-posts col-blog\">\r\n");
#nullable restore
#line 6 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
         foreach (merigurumiblog.Post Post in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""post row"">
                <div class=""col-sm-4"">
                    <figure>
                        <a href=""blog-post.html"">
                            <div class=""text-overlay"">
                                <div class=""info""><span>Hepsini Oku</span></div>
                            </div>
                            <img src=""style/images/art/b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 548, "\"", 554, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </a>\r\n                    </figure>\r\n                </div>\r\n                <div class=\"col-sm-8 post-content\">\r\n                    <div class=\"meta\">\r\n                        <span class=\"date\">");
#nullable restore
#line 21 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
                                      Write(Post.Postdate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"comments\">\r\n                            <a href=\"#\">");
#nullable restore
#line 23 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
                                   Write(Post.Comment.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"icon-chat-1\"></i></a>\r\n                        </span>\r\n                    </div>\r\n                    <h2 class=\"post-title\"><a href=\"blog-post.html\">");
#nullable restore
#line 26 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
                                                               Write(Post.Postname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
                  Write(Post.Postcontent.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\meri\Documents\project\merigurumiblog\merigurumiblog\merigurumiblog\Controllers\PostListeleWidget.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<merigurumiblog.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
