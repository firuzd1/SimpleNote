namespace DataAccess;

public interface ICategoryRepository
{
    public Task<Category> CreateCategory(Category category, CancellationToken token);
    public Task<bool> DeleteCategory(long id, CancellationToken token);
    public Task<Category> ChangeCategory(long id, string newName, CancellationToken token);
}