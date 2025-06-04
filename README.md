# SimpleServer.ApiTests

This repository contains automated tests for the [SimpleServer](https://github.com/hrosicka/SimpleServer) project.

## Overview

The purpose of this repository is to provide integration and API tests for the [SimpleServer](https://github.com/hrosicka/SimpleServer) application. The tests are written in C# using [NUnit](https://nunit.org/) and [HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient) for verifying the behavior of the API endpoints.

## What is being tested?

- **Repository under test:** [hrosicka/SimpleServer](https://github.com/hrosicka/SimpleServer)
- **Main focus:** Verifying that API endpoints (such as `/hello?name=...`) return correct responses
- **Test Framework:** NUnit
- **Language:** C#

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- The [SimpleServer](https://github.com/hrosicka/SimpleServer) application running locally (default: `http://localhost:8080`)

### Running the tests

1. Clone this repository:
   ```bash
   git clone https://github.com/hrosicka/SimpleServer.ApiTests.git
   cd SimpleServer.ApiTests
   ```

2. Ensure your instance of SimpleServer is running on `http://localhost:8080`.

3. Run the tests:
   ```bash
   dotnet test
   ```

### Configuration

You can adjust the tested API endpoint by editing the `_baseUrl` variable in the test classes (e.g., `ApiTests.cs`).

## Example Test

```csharp
[Test]
public async Task Hello_WithName_ReturnsGreeting()
{
    using var client = new HttpClient();
    var response = await client.GetAsync($"{_baseUrl}/hello?name=Hanka");
    Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    var content = await response.Content.ReadAsStringAsync();
    Assert.That(content, Does.Contain("Hanka"));
}
```

## License

MIT

---
> This repository is dedicated to testing the [SimpleServer](https://github.com/hrosicka/SimpleServer) project.
