public abstract class BaseEntity : IEntity
{
    public int Id { get; set; }
    public bool IsSynced { get; set; } = false;
    public DateTime LastModified { get; set; } = DateTime.UtcNow;
}
