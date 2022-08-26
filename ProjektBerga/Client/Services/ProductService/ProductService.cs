using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjektBerga.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)    
        {
            this.http = http;
        }
        public async Task LoadProducts(string categoryUrl= null)
        {
            if( categoryUrl == null)
            {
                Products = await http.GetFromJsonAsync<List<Product>>($"api/Product");
            }
            else
            {
                Products = await http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}
