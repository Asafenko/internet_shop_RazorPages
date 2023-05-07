using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models;

public class ProductAdditionModel
{
    [Required] public string Category { get; set; }
    [Required] public string Name { get; set; }
    [Range(1, 10_000)] public decimal Price { get; set; }
    [Range(0, 1000)] public int Count { get; set; }
     public string Description { get; set; }
    public string Picture { get; set; }
}