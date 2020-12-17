using System.Threading.Tasks;
using merigurumiblogFront.ApiServices.Interfaces;
using merigurumiblogFront.Filters;
using merigurumiblogFront.Models;
using Microsoft.AspNetCore.Mvc;

namespace merigurumiblogFront.Areas.Admin.Controllers{
    [Area("Admin")]
    public class BlogController : Controller{
       private readonly IBlogApiService _blogApiService;
       public BlogController(IBlogApiService blogApiService)
       {
           _blogApiService=blogApiService;
       }
       [JwtAuthorize]
        public async Task<IActionResult> Index(){
            return View(await _blogApiService.GetAllAsync());
        }
        public IActionResult Create(){
            return View(new BlogAddModel());
        }
        [HttpPost]
        public async  Task<IActionResult> Create(BlogAddModel model){
           if(ModelState.IsValid){
                await _blogApiService.AddAsync(model);
                return RedirectToAction("Index");
           }
            return View(model);
        }
        public async Task<IActionResult> Update(int id){
            var blogList=await _blogApiService.GetByIdAsync(id);

            return View(new BlogUpdateModel{
               Id=blogList.Id,
               Title=blogList.Title,
               Description=blogList.Description,
               ShortDescription=blogList.ShortDescription 
            });
        }
        [HttpPost]
        public async Task<IActionResult> Update(BlogUpdateModel model)
        {
            if(ModelState.IsValid){
                await _blogApiService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int id){
            await _blogApiService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}