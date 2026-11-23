using SmilingMoonFarmWeb.Apis;
using SmilingMoonFarmWeb.Entities;
using SmilingMoonFarmWeb.Network;

namespace SmilingMoonFarmWeb;

public interface IProductsService
{
    public Task<List<Product>> GetFeaturedProducts();
}
public class ProductsService(IProductsApi api): IProductsService
{
    public async Task<List<Product>> GetFeaturedProducts()
    {
        var apiProducts = api.GetProducts();
        return ToProducts(apiProducts);
    }
    
    private List<Product> ToProducts(List<NetworkProduct> networkProducts)
    {
        var products = new List<Product>();
        foreach (var networkProduct in networkProducts)
        {
            var images = networkProduct.ProductImages.Select(i => new Image(i.Url)).ToList();
            products.Add(new Product(Images:images, Price: networkProduct.BasePriceCents, Name: networkProduct.Name));
        }
        
        return products;
    }
}