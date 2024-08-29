// File: SyncService.cs
using System.Linq;
using System.Threading.Tasks;

public class SyncService<T> : ISyncService<T> where T : class, IEntity
{
    private readonly IRepository<T> _repository;
    private readonly IHttpClientWrapper _httpClientWrapper;

    public SyncService(IRepository<T> repository, IHttpClientWrapper httpClientWrapper)
    {
        _repository = repository;
        _httpClientWrapper = httpClientWrapper;
    }

    public async Task SyncDataAsync()
    {
        var unsyncedEntities = await _repository.GetUnsyncedEntitiesAsync();

        if (unsyncedEntities.Any())
        {
            var response = await _httpClientWrapper.PostAsync($"https://b1cff3c7-8222-44d1-aebe-bcab07098544.mock.pstmn.io/{typeof(T).Name.ToLower()}/sync", unsyncedEntities);

            if (response.IsSuccessStatusCode)
            {
                await _repository.UpdateEntitiesAsync(unsyncedEntities);
            }
            else
            {
                Console.WriteLine($"Sync failed for {typeof(T).Name} with status code: {response.StatusCode}");
            }
        }
    }
}
