using AdminPannelLast;
using AdminPannelLast.Services.Api;
using AdminPannelLast.Services.Auth;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// ????? ??? API ??????? (??? ???? ??? StoreAPI ???)
var apiBaseAddress = new Uri("https://storeapi-marwan-dkbqbsdebmhkguc3.canadacentral-01.azurewebsites.net/");

// HttpClient ??? ??????? ???? ???? (??????? ???????? ?? ?????)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = apiBaseAddress });

// ????? ?????? ?? LocalStorage
builder.Services.AddScoped<ITokenStorage, LocalStorageTokenStorage>();

// HttpClient ???? ?????? ???? Authorization Bearer ????????
builder.Services.AddTransient<AuthorizedHttpMessageHandler>();
builder.Services.AddHttpClient<AdminDashboardService>(client =>
{
    client.BaseAddress = apiBaseAddress;
}).AddHttpMessageHandler<AuthorizedHttpMessageHandler>();

builder.Services.AddScoped<LanguageService>();

await builder.Build().RunAsync();
