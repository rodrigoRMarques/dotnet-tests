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