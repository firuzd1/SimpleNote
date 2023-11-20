
namespace Note.DataAccess;


public sealed class EfCoreCategoryRepository : ICategoryRepository
{
    private readonly NoteDbContext _db;
    public EfCoreCategoryRepository(NoteDbContext dbContext)
    {
        _db = dbContext;
    }
    public async Task<Category> ChangeCategoryAsync(long id, string newName, CancellationToken token)
    {
        Category? category = await _db.categories.FindAsync(id, token);
        if(category is null)
            throw new NotFoundExeption("Category for changing not found!");
        
        category.Name = newName;
        await _db.SaveChangesAsync(token);
        return category;

    }

    public async Task<Category> CreateCategoryAsync(Category category, CancellationToken token)
    {
        await _db.categories.AddAsync(category, token);
        await _db.SaveChangesAsync(token);
        return category;
    }

    public async Task<bool> DeleteCategoryAsync(long id, CancellationToken token)
    {
        Category? category = await _db.categories.FindAsync(id, token);
        if(category is null)
            throw new NotFoundExeption("There is no category for delete!");

        _db.categories.Remove(category);
        await _db.SaveChangesAsync(token);
        return true;
    }
}