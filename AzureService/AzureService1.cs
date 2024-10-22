public class AzureService : IAzureService
{
    private readonly IHttpClient _client;

    public AzureService()
    {
        _client = new HttpClient();
    }
    public void Login()
    {
        _client.PostAsync("https://login.microsoftonline.com", new StringContent("username=abc&password=123"));
    }
}