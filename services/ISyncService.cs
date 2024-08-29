public interface ISyncService<T> where T : class, IEntity
{
    Task SyncDataAsync();
}
