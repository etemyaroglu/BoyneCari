using BoyneCari.Models.Requests.Category;
using BoyneCari.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] Guid id)
        {
            return Ok(await categoryService.GetCategoryByIdAsync(id));
        }


        [HttpGet("list")]
        public IActionResult GetCategories()
        {
            return Ok(categoryService.GetCategories());

        }
        [HttpGet("filter")]
        public IActionResult GetCategoriesFilter([FromQuery] RequestCategoryFilter model)
        {
            return Ok(categoryService.GetCategoryFilter(model));
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPost]
        public IActionResult CreateCategory([FromBody] RequestCategoryInsert request)
        {
            return Ok(categoryService.InsertCategory(request));
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPut("{id:guid}")]
        public IActionResult UpdateCategory([FromRoute] Guid id, [FromBody] RequestCategoryUpdate request)
        {
            return Ok(categoryService.UpdateCategory(id, request));
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteCategory([FromRoute] Guid id)
        {
            categoryService.DeleteCategoryById(id);
            return Ok();
        }
        #endregion

    }
}
