public class TransferRequest : BaseEntity
{
    public required int ProductId { get; set; }
    public required Product product { get; set; }
    public int StoreLocationId { get; set; }
    public StoreLocation? storeLocation { get; set; }
    public int Quantity { get; set; }

}