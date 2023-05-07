namespace internet_shop_RazorPages;

public interface ICatalogCategory
{
    void AddCategory(Category category);
    IReadOnlyCollection<Category> GetCategories();
}