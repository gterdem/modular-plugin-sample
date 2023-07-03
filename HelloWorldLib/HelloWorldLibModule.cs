using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace HelloWorldLib;

[DependsOn(
    typeof(AbpAspNetCoreMvcModule))]
public class HelloWorldLibModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<HelloOptions>(configuration.GetSection("Hello"));
    }
}