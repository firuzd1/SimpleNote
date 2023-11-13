using Note.DataAccess;
namespace BusinessLogic;


public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<CategoryDTO> ChangeCategoryAsync(long id, string newName, CancellationToken token)
    {
        Category category = await _categoryRepository.ChangeCategory(id, newName, token);
        return category.ToCategoryDTO();
    }

    public async Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDTO, CancellationToken token)
    {
        Category category = await _categoryRepository.CreateCategory(categoryDTO.ToCategory(), token);
        return category.ToCategoryDTO();
    }

    public Task<bool> DeleteCategoryAsync(long id, CancellationToken token) 
        => _categoryRepository.DeleteCategory(id, token);
}