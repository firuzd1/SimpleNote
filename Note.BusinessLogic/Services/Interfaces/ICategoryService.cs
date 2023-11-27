namespace BusinessLogic;
public interface ICategoryService
{
    public Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDTO, CancellationToken token);
    public Task<bool> DeleteCategoryAsync(long id, CancellationToken token);
    public Task<CategoryDTO> ChangeCategoryAsync(long id, string newName, CancellationToken token);
    public Task<CategoryDTO> GetCategoryAsync(long id, CancellationToken token);
}