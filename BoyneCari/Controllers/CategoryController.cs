using BoyneCari.Models.Requests.Category;
using BoyneCari.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BoyneCari.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region .ctor
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        #endregion

        #region Methods

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] string id)
        {
            var category = await categoryService.GetCategoryByIdAsync(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }


        [HttpGet("list")]
        public IActionResult GetCategories()
        {
            var categories = categoryService.GetCategories();
            if (categories == null || !categories.Any())
                return NotFound();
            return Ok(categories);

        }
        [HttpGet("filter")]
        public IActionResult GetCategoriesFilter([FromQuery] RequestCategoryFilter model)
        {
            var categories = categoryService.GetCategoryFilter(model);
            if (categories == null || !categories.Any())
                return NotFound();
            return Ok(categories);
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPost]
        public IActionResult CreateCategory([FromBody] RequestCategoryInsert request)
        {
            return Ok(categoryService.InsertCategory(request));
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromRoute] string id, [FromBody] RequestCategoryUpdate request)
        {
            return Ok(categoryService.UpdateCategory(id, request));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory([FromRoute] string id)
        {
            categoryService.DeleteCategoryById(id);
            return Ok();
        }
        #endregion

    }
}
