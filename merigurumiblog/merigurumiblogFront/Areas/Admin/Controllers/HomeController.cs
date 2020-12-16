using merigurumiblogFront.Filters;
using Microsoft.AspNetCore.Mvc;

namespace merigurumiblogFront.Areas.Admin.Controllers{
    [Area("Admin")]
    public class HomeController : Controller{
        [JwtAuthorize]
        public IActionResult Index(){
            return View();
        }
    }
}