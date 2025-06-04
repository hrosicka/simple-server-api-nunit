using System.Net;
using NUnit.Framework;

namespace SimpleServer.ApiTests;

public class ApiTests
{
    private string _baseUrl = "http://localhost:8080";

    [Test]
    public async Task Hello_WithName_ReturnsGreeting()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync($"{_baseUrl}/hello?name=Hanka");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var content = await response.Content.ReadAsStringAsync();
        Assert.That(content, Does.Contain("Hanka"));
    }
}