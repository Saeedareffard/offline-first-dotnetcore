public class Inventory : BaseEntity
{
    public int ProductId { get; set; }
    public required Product Product { get; set; }
    public int StoreLocationId { get; set; }
    public StoreLocation? StoreLocation { get; set; }
    public int Quantity { get; set; }
}
