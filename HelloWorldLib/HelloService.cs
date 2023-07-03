using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace HelloWorldLib;

public class HelloService : ITransientDependency
{
    private readonly HelloOptions _options;

    public HelloService(IOptions<HelloOptions> options)
    {
        _options = options.Value;
    }

    public string GetMessage()
    {
        return _options.Message;
    }
}