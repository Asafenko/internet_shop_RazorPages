using internet_shop_RazorPages;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Models;

namespace RazorPages.Controllers;

public class CatalogController : Controller
{
    private readonly ICatalog _catalog;
    private readonly ICatalogCategory _category;

    public CatalogController(ICatalog catalog, ICatalogCategory categoryCatalog)
    {
        _catalog = catalog;
        _category = categoryCatalog;
    }

    public IActionResult ProductList()
    {
        return View(_catalog);
    }


    [HttpGet]
    public IActionResult ProductAddition()
    {
        return View(_category);
    }

    [HttpPost]
    public IActionResult ProductAddition([FromForm] ProductAdditionModel postModel)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem();
        }

        var maxId = _catalog.GetProducts().Max(it => it.id);
        var newId = maxId + 1;
        var newProduct = new Product(postModel.Category, postModel.Name, postModel.Price, postModel.Count,
            postModel.Picture, postModel.Description, newId);
        _catalog.AddProduct(newProduct);
        ViewData["catalog"] = "Product Added";
        return View(_category);
    }


    [HttpGet]
    public IActionResult CategoryAddition()
    {
        return View(_category);
    }

    [HttpPost]
    public IActionResult CategoryAddition([FromForm] CategoryAdditionModel postModel)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem();
        }

        var newCategory = new Category(postModel.Name);
        _category.AddCategory(newCategory);
        ViewData["category"] = "Category Added";
        return View(_category);
    }


    public IActionResult ProductInfo(int parentId)
    {
        return View(_catalog.GetProduct(parentId));
    }
}