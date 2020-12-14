using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using merigurumiblogFront.ApiServices.Interfaces;
using merigurumiblogFront.Models;
using Newtonsoft.Json;

namespace merigurumiblogFront.ApiServices.Concrete{
    public class CategoryApiManager : ICategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiManager(HttpClient httpClient)
        {
            _httpClient=httpClient;
            _httpClient.BaseAddress= new Uri("http://localhost:60946/api/categories/");
        }
        public async Task<List<CategoryListModel>> GetAllAsync()
        {
           var responseMessage=await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode){
             return JsonConvert.DeserializeObject<List<CategoryListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}