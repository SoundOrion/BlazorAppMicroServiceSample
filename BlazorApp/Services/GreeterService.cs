//using Microsoft.Extensions.Options;
//using System.Text.Json;

//namespace BlazorApp.Services;

//public class GreeterService
//{
//    private readonly GreetApi.Greeter.GreeterClient _client;

//    public GreeterService(GreetApi.Greeter.GreeterClient client)
//    {
//        _client = client;
//    }

//    public async Task<string> SayHello()
//    {
//        var reply = await _client.SayHelloAsync(new GreetApi.HelloRequest { Name = "Hello" });
//        return reply.Message;
//    }
//}

using Microsoft.Extensions.Options;
using System.Text.Json;

namespace BlazorApp.Services;

public class GreeterService
{
    private readonly HttpClient _httpClient;

    private readonly string _remoteServiceBaseUrl;

    public GreeterService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        var url = "http://webapigateway";
        //var url = "http://httpaggregator";
        //var url = "http://localhost:5121";
        _remoteServiceBaseUrl = $"{url}/api/v1/sample/";
    }

    public async Task<string> SayHello()
    {
        var uri = _remoteServiceBaseUrl;

        var responseString = await _httpClient.GetStringAsync(uri);

        //var message = JsonSerializer.Deserialize<string>(responseString, new JsonSerializerOptions
        //{
        //    PropertyNameCaseInsensitive = true
        //});

        return responseString;
    }
}

