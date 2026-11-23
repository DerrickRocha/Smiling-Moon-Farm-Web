using SmilingMoonFarmWeb.Network;

namespace SmilingMoonFarmWeb.Apis;

public interface IProductsApi
{
    public List<NetworkProduct> GetProducts();
}

public class ProductsApi : IProductsApi
{
    
    public List<NetworkProduct> GetProducts()
    {
        var p1 = new NetworkProduct()
        {
            Name = "test"
        };
        
        var p2 = new NetworkProduct()
        {
            Name = "test"
        };
        
        var p3 = new NetworkProduct()
        {
            Name = "test"
        };
        var products = new List<NetworkProduct>
        {
            p1,
            p2,
            p3
        };
        return products;
    }
}