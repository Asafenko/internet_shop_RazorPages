using System.Collections.Concurrent;

namespace internet_shop_RazorPages;

public interface ICatalog
{
    List<Product> GetProducts(); 
    Product GetProduct(int id);
    void AddProduct(Product newBook);
    void Clear();
}