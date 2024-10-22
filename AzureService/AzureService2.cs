public class AzureService : IAzureService
{
    private readonly IHttpClient _client;
    
    public AzureService(IHttpClient client)
    {
        _client = client;
    }

    public void Login()
    {
        _client.PostAsync("https://login.microsoftonline.com", new StringContent("username=abc&password=123"));
    }
}