namespace internet_shop_RazorPages;

public class Catalog : ICatalog
{
    private readonly IDate _date;
    public Catalog(IDate date)
    {
        _date = date;
    }


    private List<Product> _products = new()
    {
        new("Book", "qqq", 200m, 3, "http://smartmobilestudio.com/wp-content/uploads/2012/06/leather-book-preview.png",
            "good", 1),
        new("Book", "qqq", 220m, 3, "https://d2j6dbq0eux0bg.cloudfront.net/images/24595415/1297476103.jpg", "bad", 2),
        new("Book", "qqq", 330m, 3, "https://www.collinsdictionary.com/images/full/book_181404689_1000.jpg",
            "very good", 3)
    };

    

    private bool isDay = true;

    public List<Product> GetProducts()
    {
        if (_date.GetDate() == DayOfWeek.Saturday && isDay)
        {
            foreach (var product in _products)
            {
                product.price *= 0.7m;
            }

            isDay = false;
        }

        return _products;
    }

    // public void AddProduct(string category,string name,decimal price,int count,string picture,int id)
    // {
    //     var NewBook = new Product(category,name, price, count, picture,id);
    //     AddProduct(NewBook);
    // }

    public Product GetProduct(int id)
    {
        return _products.First(it => it.id == id);
    }

    public void AddProduct(Product newBook)
    {
        _products.Add(newBook);
    }


    public void Clear()
    {
        _products.Clear();
    }
}