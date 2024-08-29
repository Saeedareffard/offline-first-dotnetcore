public interface IEntity
{
    int Id { get; set; }
    bool IsSynced { get; set; }
    DateTime LastModified { get; set; }
}
