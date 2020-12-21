using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using merigurumiblogFront.ApiServices.Interfaces;
using merigurumiblogFront.Extensions;
using merigurumiblogFront.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace merigurumiblogFront.ApiServices.Concrete
{
    public class BlogApiManager : IBlogApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BlogApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor=httpContextAccessor;
            _httpClient=httpClient;
            _httpClient.BaseAddress=new Uri("http://localhost:60946/api/blogs/");
        }
        public async Task<List<BlogListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<BlogListModel> GetByIdAsync(int id)
        {
             var responseMessage = await _httpClient.GetAsync($"{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<BlogListModel>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id){
            var responseMessage = await _httpClient.GetAsync($"GetAllByCategoryId/{id}");
            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task AddAsync(BlogAddModel model){
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if(model.Image!=null){
                var bytes= await System.IO.File.ReadAllBytesAsync(model.Image.FileName);
                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType= new MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent, nameof(BlogAddModel.Image),model.Image.FileName);
            }
            var user= _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId=user.Id;

            formData.Add(new StringContent(model.AppUserId.ToString()), nameof(BlogAddModel.AppUserId));
             formData.Add(new StringContent(model.ShortDescription), nameof(BlogAddModel.ShortDescription));
              formData.Add(new StringContent(model.Description), nameof(BlogAddModel.Description));
               formData.Add(new StringContent(model.Title), nameof(BlogAddModel.Title));
            
            _httpClient.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));
            await _httpClient.PostAsync("",formData);
        }
        public async Task UpdateAsync(BlogUpdateModel model){
            MultipartFormDataContent formData = new MultipartFormDataContent();
            if(model.Image!=null){
                var bytes= await System.IO.File.ReadAllBytesAsync(model.Image.FileName);
                ByteArrayContent byteContent = new ByteArrayContent(bytes);
                byteContent.Headers.ContentType= new MediaTypeHeaderValue(model.Image.ContentType);

                formData.Add(byteContent, nameof(BlogAddModel.Image),model.Image.FileName);
            }
            var user= _httpContextAccessor.HttpContext.Session.GetObject<AppUserViewModel>("activeUser");
            model.AppUserId=user.Id;

            formData.Add(new StringContent(model.Id.ToString()),nameof(BlogUpdateModel.Id));
            formData.Add(new StringContent(model.AppUserId.ToString()), nameof(BlogAddModel.AppUserId));
             formData.Add(new StringContent(model.ShortDescription), nameof(BlogAddModel.ShortDescription));
              formData.Add(new StringContent(model.Description), nameof(BlogAddModel.Description));
               formData.Add(new StringContent(model.Title), nameof(BlogAddModel.Title));
                
            
            _httpClient.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));
            await _httpClient.PutAsync($"{model.Id}",formData);
        }
        public async Task DeleteAsync(int id){
           _httpClient.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("Bearer", _httpContextAccessor.HttpContext.Session.GetString("token"));
            await _httpClient.DeleteAsync($"{id}");
        }
        public async Task<List<CommentListModel>> GetCommentsAsync(int blogId, int? parentCommentId){
            var responseMessage= await _httpClient.GetAsync($"{blogId}/GetComments?parentCommentId={parentCommentId}");

            if(responseMessage.IsSuccessStatusCode){
                return JsonConvert.DeserializeObject<List<CommentListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }

            return null;
        }
    }
}
