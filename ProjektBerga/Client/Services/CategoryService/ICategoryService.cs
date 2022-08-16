using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Client.Services.CategoryService
{
    interface ICategoryService
    {
         List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
