using BusinessLogic;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("categories")]
public sealed class CategoryController : ControllerBase
{

    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpPatch("{id}")]
    public Task<CategoryDTO> ChangeCategoryAsync(long id, [FromQuery]string newName, CancellationToken token) 
        => _categoryService.ChangeCategoryAsync(id, newName, token);

    [HttpPost]
    public Task<CategoryDTO> CreateCategoryAsync([FromBody] CategoryDTO categoryDTO, CancellationToken token) 
        => _categoryService.CreateCategoryAsync(categoryDTO, token);

    [HttpGet("{id}")]
    public Task<CategoryDTO> GetCategoryAsync(long id, CancellationToken token)
        => _categoryService.GetCategoryAsync(id, token);

    [HttpDelete("{id}")]
    public Task<bool> DeleteCategoryAsync(long id, CancellationToken token) 
        => _categoryService.DeleteCategoryAsync(id, token);
}
