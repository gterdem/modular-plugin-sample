using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace HelloWorldLib;

[Route("")]
public class HelloController : AbpController
{
    private readonly HelloService _helloService;

    public HelloController(HelloService helloService)
    {
        _helloService = helloService;
    }

    public string Get()
    {
        return _helloService.GetMessage();
    }
}