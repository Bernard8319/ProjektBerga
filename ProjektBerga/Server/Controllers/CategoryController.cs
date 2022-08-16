using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjektBerga.Server.Services.CategoryService;
using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService){
            this.categoryService = categoryService;
        }


        
        [HttpGet]
        public async Task <ActionResult<List<Category>>> GetCategories()
        {

            return Ok(await categoryService.GetCategories());
            
        }
    }
}
