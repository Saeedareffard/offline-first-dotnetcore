public class Product : BaseEntity
{
    public required string SKU { get; set; }
    public required string Name { get; set; }

    public decimal Price { get; set; }
    public ICollection<Inventory>? Inventory { get; set; }
}