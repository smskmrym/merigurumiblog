using Microsoft.AspNetCore.Mvc;
using merigurumiblogFront.ApiServices.Interfaces;

namespace UdemyBlogFront.ViewComponents{
    public class LastFiveBlog : ViewComponent{
        private readonly IBlogApiService _blogApiService;
        public LastFiveBlog(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;    
        }
        public IViewComponentResult Invoke(){

            return View(_blogApiService.GetLastFiveAsync().Result);
        }
    }
}