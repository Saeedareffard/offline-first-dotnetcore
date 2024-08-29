
public interface IRepository<T> where T : class, IEntity
{
    Task<List<T>> GetUnsyncedEntitiesAsync();
    Task UpdateEntitiesAsync(List<T> entities);
}
