using Microsoft.EntityFrameworkCore;
using ProjektBerga.Server.Data;
using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext context;

        public CategoryService(DataContext context)
        {
            this.context = context;
        }
        public async Task<List<Category>> GetCategories()
        {

            return  await context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
