namespace Aggregators.Services;

public interface IGreeterService
{
    Task<string> SayHello();
}