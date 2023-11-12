using DataAccess;
namespace BusinessLogic;


public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<CategoryDTO> ChangeCategory(long id, string newName, CancellationToken token)
    {
        Category category = await _categoryRepository.ChangeCategory(id, newName, token);
        return category.ToCategoryDTO();
    }

    public async Task<CategoryDTO> CreateCategory(CategoryDTO categoryDTO, CancellationToken token)
    {
        Category category = await _categoryRepository.CreateCategory(categoryDTO.ToCategory(), token);
        return category.ToCategoryDTO();
    }

    public Task<bool> DeleteCategory(long id, CancellationToken token) 
        => _categoryRepository.DeleteCategory(id, token);
}