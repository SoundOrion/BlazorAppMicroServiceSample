namespace Aggregators.Services;
public class GreeterService: IGreeterService
{
    private readonly GreetApi.Greeter.GreeterClient _client;

    public GreeterService(GreetApi.Greeter.GreeterClient client)
    {
        _client = client;
    }

    public async Task<string> SayHello()
    {
        var reply = await _client.SayHelloAsync(new GreetApi.HelloRequest { Name = "GreeterClient" });
        return reply.Message;
    }
}
