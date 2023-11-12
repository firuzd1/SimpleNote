namespace BusinessLogic;
public interface ICategoryService
{
    public Task<CategoryDTO> CreateCategory(CategoryDTO categoryDTO, CancellationToken token);
    public Task<bool> DeleteCategory(long id, CancellationToken token);
    public Task<CategoryDTO> ChangeCategory(long id, string newName, CancellationToken token);
}