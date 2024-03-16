using HotelManagementBlazorApp.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HotelManagementBlazorApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(gs => new HttpClient());


            builder.Services.AddScoped<GuestService>();

            await builder.Build().RunAsync();
        }
    }
}
