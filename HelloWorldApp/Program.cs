using HelloWorldApp;
using Volo.Abp.Modularity.PlugIns;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseAutofac();

builder.Services.AddApplication<HelloWorldAppModule>(options =>
{
    options.PlugInSources.AddFolder(
        @"c:\plugins"
        );
});

var app = builder.Build();

app.InitializeApplication();

app.Run();