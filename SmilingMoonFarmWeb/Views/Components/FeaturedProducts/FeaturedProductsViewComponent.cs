using Microsoft.AspNetCore.Mvc;

namespace SmilingMoonFarmWeb.Views.Components.FeaturedProducts;

public class FeaturedProductsViewComponent(IProductsService productsService): ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var products = await productsService.GetFeaturedProducts();
        return View(products);
    }
}