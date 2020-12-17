using Microsoft.AspNetCore.Mvc;
using merigurumiblogFront.Extensions;
using merigurumiblogFront.Filters;
using merigurumiblogFront.Models;

namespace merigurumiblogFront.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [JwtAuthorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}