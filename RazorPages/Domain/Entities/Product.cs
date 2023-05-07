namespace internet_shop_RazorPages;

public class Product
{
    public Product(string category,string name, decimal price, int count,string picture,string description,int id)
    {
        this.category = category;
        this.name = name;
        this.price = price;
        this.count = count;
        this.picture = picture;
        this.description = description;
        this.id = id;
    }

    public string category { get; set; }
    public string name { get; set; }
    public decimal price { get; set; }
    public int count { get; set; }
    public string picture { get; set; }
    public string description { get; set; }
    public int id { get; set; }
}