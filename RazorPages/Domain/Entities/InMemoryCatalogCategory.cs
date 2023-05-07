using System.Collections.Concurrent;

namespace internet_shop_RazorPages;

public class CatalogCategory : ICatalogCategory
{
    private List<Category> _categories = new()
    {
        new("Book"),
        new("Food"),
        new("Clothes")
    };

    public void AddCategory(Category category)
    {
        _categories.Add(category);
    }

    public IReadOnlyCollection<Category> GetCategories()
    {
        return _categories;
    }
}