using Microsoft.AspNetCore.Mvc;
using SmilingMoonFarmWeb.Entities;

namespace SmilingMoonFarmWeb.Views.Components.ProductCard;

public class ProductCardViewComponent: ViewComponent
{

    public async Task<IViewComponentResult> InvokeAsync(Product product)
    {
        return View(product);
    }
    
}