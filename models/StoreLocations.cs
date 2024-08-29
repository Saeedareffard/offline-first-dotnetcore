public class StoreLocation : BaseEntity
{
    public required string Name { get; set; }
    public required string Address { get; set; }
    public ICollection<Inventory>? inventories { get; set; }
}