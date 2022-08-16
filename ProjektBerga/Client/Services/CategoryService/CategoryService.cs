using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjektBerga.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }



        public  async Task LoadCategories()
        {
            Categories = await http.GetFromJsonAsync<List<Category>>("api/Category");
            
        }
    }
}
