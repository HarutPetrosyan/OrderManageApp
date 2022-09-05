using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OrderManageApp;
using OrderManageApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddHttpClient();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddScoped<AppServices>();
builder.Services.AddHttpClient<ISupplierService, SupplierService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7210/");
});

await builder.Build().RunAsync();
