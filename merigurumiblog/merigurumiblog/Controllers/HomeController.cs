using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using merigurumiblog.Models;

namespace merigurumiblog.Controllers
{
    public class HomeController : Controller
    {
        MerigurumiblogContext context = new MerigurumiblogContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public PartialViewResult PostListeleWidget()
        {
            return PartialView(context.Post.ToList());
        }
    }
}
