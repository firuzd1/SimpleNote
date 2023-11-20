namespace Note.DataAccess;

public interface ICategoryRepository
{
    public Task<Category> CreateCategoryAsync(Category category, CancellationToken token);
    public Task<bool> DeleteCategoryAsync(long id, CancellationToken token);
    public Task<Category> ChangeCategoryAsync(long id, string newName, CancellationToken token);
}