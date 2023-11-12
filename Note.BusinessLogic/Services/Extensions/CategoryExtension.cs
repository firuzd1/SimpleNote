using DataAccess;
namespace BusinessLogic;


public static class CategoryExtension
{
    public static CategoryDTO ToCategoryDTO(this Category category)
    {
        CategoryDTO categoryDTO = new(
            category.Id,
            category.Name
        );
        return categoryDTO;
    }

    public static Category ToCategory(this CategoryDTO  categoryDTO)
    {
        Category category = new()
        {
            Id = categoryDTO.Id,
            Name = categoryDTO.Name
        };
        return category;
    }
}