
public interface IHttpClientWrapper
{
    Task<HttpResponseMessage> PostAsync<T>(string uri, T data);
}
