using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models;

public class CategoryAdditionModel
{
    [Required]
    public string Name { get; set; }
}