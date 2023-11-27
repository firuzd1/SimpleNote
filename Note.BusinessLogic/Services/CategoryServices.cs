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
        Category category = await _categoryRepository.ChangeCategoryAsync(id, newName, token);
        return category.ToCategoryDTO();
    }

    public async Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDTO, CancellationToken token)
    {
        Category category = await _categoryRepository.CreateCategoryAsync(categoryDTO.ToCategory(), token);
        return category.ToCategoryDTO();
    }

    public async Task<CategoryDTO> GetCategoryAsync(long id, CancellationToken token)
    {
        Category category = await _categoryRepository.GetCategoryAsync(id, token);
        return category.ToCategoryDTO();
    }

    public Task<bool> DeleteCategoryAsync(long id, CancellationToken token) 
        => _categoryRepository.DeleteCategoryAsync(id, token);
}