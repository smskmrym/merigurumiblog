using System.Threading.Tasks;
using merigurumiblogFront.ApiServices.Interfaces;
using merigurumiblogFront.Enums;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace merigurumiblogFront.TagHelpers
{
    [HtmlTargetElement("getblogimage")]
    public class ImageTagHelper : TagHelper
    {
        private readonly IImageApiService _imageService;
        public ImageTagHelper(IImageApiService imageService)
        {
            _imageService = imageService;

        }
        public int Id { get; set; }
        public BlogImageType BlogImageType { get; set; } = BlogImageType.BlogHome;
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var blob = await _imageService.GetBlogImageByIdAsync(Id);

            string html = string.Empty;
            if (BlogImageType == BlogImageType.BlogHome)
            {
                html = $"<img src='{blob}' class='card-img-top'/>";
            }
            else
            {
                html = $"<img src='{blob}' class='img-fluid rounded'/>";
            }
            output.Content.SetHtmlContent(html);

        }
    }
}