namespace SmilingMoonFarmWeb.Network;

public class NetworkProduct
{
    public int Id { get; set; }
    
    public int TenantId { get; set; }
    
    public int TaxCategoryId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int BasePriceCents { get; set; }
    
    public int WeightGrams { get; set; }
    
    public bool RequiresShipping { get; set; } = true; 
    
    public bool IsActive { get; set; }
    
    public bool IsEnhancedPaymentRequired { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
    
    
    public byte[] RowVersion { get; set; } = null!;
    
    public List<NetworkProductOption> ProductOptions { get; set; } = new List<NetworkProductOption>();

    public List<NetworkProductImage> ProductImages { get; set; } = new List<NetworkProductImage>();
}