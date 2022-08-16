using Microsoft.EntityFrameworkCore;
using ProjektBerga.Server.Data;
using ProjektBerga.Server.Services.CategoryService;
using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService categoryService;
        private readonly DataContext context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            this.categoryService = categoryService;
            this.context = context;
        }
        
       
        public async Task<List<Product>> GetAllProducts()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await categoryService.GetCategoryByUrl(categoryUrl);
            return await context.Products.Where(p => p.CategoryId == category.Id ).ToListAsync();
        }

        
    }
}
