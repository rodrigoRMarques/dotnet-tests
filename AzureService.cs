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

//create unit tests for AzureService
[TestClass]
public class AzureServiceTests
{
    [TestMethod]
    public void LoginTest()
    {
        var mockHttpClient = new Mock<IHttpClient>();
        mockHttpClient.Setup(x => x.PostAsync(It.IsAny<string>(), It.IsAny<StringContent>())).Verifiable();

        var service = new AzureService(mockHttpClient.Object);
        service.Login();

        mockHttpClient.Verify(x => x.PostAsync(It.IsAny<string>(), It.IsAny<StringContent>()), Times.Once);
    }
}

//create unit tests for AzureService
[TestClass]
public class AzureServiceTests
{
    [TestMethod]
    public void LoginTest()
    {
        var service = new AzureService();
        service.Login();
    }
}